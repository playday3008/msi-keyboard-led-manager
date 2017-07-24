using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.ApplicationServices;
using MSI_Keyboard_LED_Manager.Classes;
using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MSI_Keyboard_LED_Manager {
	static class Program {
		public static Keyboard keyboard = new Keyboard();

		public static MMDevice audio_out;
		public static List<float> peaks = new List<float>();
		public static float PEAK_SAMPLES = 10;

		public static List<Profile> profiles;

		public static Profile tempProfile = null;

		static Timer timer = new Timer();

		// ------------------------------------
		// Main

		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Open the keyboard
			try {
				keyboard.Open();
			} catch (Exception e) {
				MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Config.Load();
			profiles = Profile.Load();

			// Configure NAudio
			MMDeviceEnumerator naudio_enum = new MMDeviceEnumerator();
			audio_out = naudio_enum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);

			timer.Tick += new EventHandler(TimerTick);

			// Application exit handler
			AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

			// Monitor, Lock and Power handlers
			SystemEvents.PowerModeChanged += OnPowerChange;
			PowerManager.IsMonitorOnChanged += new EventHandler(MonitorOnChanged);
			SystemEvents.SessionSwitch += new SessionSwitchEventHandler(SystemEvents_SessionSwitch);
			Update();

			// Start the interface
			Application.Run(new FrmMain());
		}

		// ------------------------------------
		// Profile change

		public static void Update() {
			if (Config.selectedProfile == -1 && profiles.Count > 0) {
				Config.selectedProfile = 0;
				Config.Save();
			}

			if ((Config.selectedProfile == -1 || !Config.enabled) && tempProfile == null) {
				keyboard.TurnOff();
				timer.Stop();
				timer.Enabled = false;
			} else if (tempProfile != null || (Config.selectedProfile != -1 && Config.enabled)) {
				Profile p = tempProfile != null ? tempProfile : p = profiles[Config.selectedProfile];

				if (p.mode == Keyboard.Mode.AUDIO2 || p.mode == Keyboard.Mode.RAINBOW) {
					timer.Enabled = true;
					timer.Interval = p.delay;
					timer.Start();
				} else {
					keyboard.TurnOff();
					timer.Stop();
					timer.Enabled = false;

					keyboard.ApplyProfile(p);
				}
			}
		}

		// ------------------------------------
		// Handlers

		// Session Switch
		static void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e) {
			switch (e.Reason) {
				// ...
				case SessionSwitchReason.SessionLock:
					if (Config.enabled) {
						keyboard.TurnOff();
						timer.Stop();
						timer.Enabled = false;
					}
					break;
				case SessionSwitchReason.SessionUnlock:
					Update();
					break;
			}
		}

		// Timer
		static void TimerTick(object sender, EventArgs e) {
			if (Config.enabled) {
				Profile p = tempProfile != null ? tempProfile : p = profiles[Config.selectedProfile];

				if (p.mode == Keyboard.Mode.AUDIO2) {
					float peak = audio_out.AudioMeterInformation.MasterPeakValue;
					peaks.Add(peak);
					if (peaks.Count > PEAK_SAMPLES)
						peaks.RemoveAt(0);

					float sum = 0;

					foreach (float v in peaks)
						sum += v;

					float average = sum / peaks.Count;

					float x1, y1, x2, y2;

					x1 = average;
					x2 = 1;
					y1 = 0;
					y2 = 1;

					float m = (y2 - y1) / (x2 - x1);

					float inter = y1 - m * x1;

					float val = m * peak + inter;

					int i = (int)(val * 3);

					if (i >= 1)
						keyboard.SetColor(Keyboard.Region.LEFT, p.color1[0].color, p.color1[0].level);
					else
						keyboard.SetColor(Keyboard.Region.LEFT, Keyboard.Color.OFF, Keyboard.Level.HIGH);

					if (i >= 2)
						keyboard.SetColor(Keyboard.Region.CENTER, p.color1[1].color, p.color1[1].level);
					else
						keyboard.SetColor(Keyboard.Region.CENTER, Keyboard.Color.OFF, Keyboard.Level.HIGH);

					if (i >= 3)
						keyboard.SetColor(Keyboard.Region.RIGHT, p.color1[2].color, p.color1[2].level);
					else
						keyboard.SetColor(Keyboard.Region.RIGHT, Keyboard.Color.OFF, Keyboard.Level.HIGH);

					keyboard.SetMode(Keyboard.Mode.NORMAL);

				} else if (p.mode == Keyboard.Mode.RAINBOW) {
				} else {
					timer.Stop();
					timer.Enabled = false;
				}

			} else {
				timer.Stop();
				timer.Enabled = false;
			}
		}

		// Process exit
		static void OnProcessExit(object sender, EventArgs e) {
			keyboard.TurnOff();
			keyboard.Close();
		}

		// Power change
		static void OnPowerChange(object sender, PowerModeChangedEventArgs e) {
			switch (e.Mode) {
				case PowerModes.Resume:
					Update();
					break;
				case PowerModes.Suspend:
					if (Config.enabled) {
						keyboard.TurnOff();
						timer.Stop();
						timer.Enabled = false;
					}
					break;
			}
		}

		// Monitor change
		static void MonitorOnChanged(object sender, EventArgs e) {
			if (Config.onScreenOff) {
				if (PowerManager.IsMonitorOn) {
					Update();
				} else {
					if (Config.enabled) {
						keyboard.TurnOff();
						timer.Stop();
						timer.Enabled = false;
					}
				}
			}
		}
	}
}
