using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HidLibrary;

namespace MSI_Keyboard_LED_Manager.Classes {
	public class Keyboard {
		HidDevice device;

		// --------------------------------------------
		// Keyboard configuration

		public const int VID = 0x1770;
		public const int PID = 0xff00;

		// --------------------------------------------
		// Command byte values

		const int SET_MODE = 65;
		const int SET_REGION_COLOR = 66;
		const int SEND_DATA = 67;
		const int CMD_END = 236;

		public enum Mode {
			NORMAL = 1, GAMING, BREATH, AUDIO, WAVE, AUDIO2, RAINBOW
		}

		public enum Region {
			LEFT = 1, CENTER, RIGHT
		}

		public enum Color {
			OFF = 0, RED, ORANGE, YELLOW, GREEN, SKY, BLUE, PURPLE, WHITE
		}

		public enum Level {
			HIGH = 0, MED, LOW, LIGHT
		}


		// --------------------------------------------
		// Member function

		public void Open() {
			HidDevice[] HidDeviceList = HidDevices.Enumerate(VID, PID).ToArray();

			if (HidDeviceList.Length < 1)
				throw new Exception("MSI Keyboard not found");

			device = HidDeviceList[0];

			if (!device.IsConnected)
				throw new Exception("MSI Keyboard not connected");

			device.OpenDevice();

			if (!device.IsOpen)
				throw new Exception("Failed to open MSI Keyboard");
		}

		public void Close() {
			if (!device.IsOpen)
				return;

			device.CloseDevice();
		}

		public void ApplyProfile(Profile p) {
			if(p.mode == Mode.BREATH || p.mode == Mode.WAVE) {
				int period = 2; // TODO
				for(int k = 0; k < 3; k++) {
					int _k = k * 3;
					SendData(SEND_DATA, _k + 1, (int)p.color1[k].color, (int)p.color1[k].level, 0);
					SendData(SEND_DATA, _k + 2, (int)p.color2[k].color, (int)p.color2[k].level, 0);
					SendData(SEND_DATA, _k + 3, period, period, period);
				}
			} else {
				SetColor(Keyboard.Region.LEFT, p.color1[0].color, p.color1[0].level);
				SetColor(Keyboard.Region.CENTER, p.color1[1].color, p.color1[1].level);
				SetColor(Keyboard.Region.RIGHT, p.color1[2].color, p.color1[2].level);
			}

			SetMode(p.mode);
		}

		bool SendData(int type, int val1, int val2, int val3, int val4) {
			if (!device.IsOpen)
				throw new Exception("Device not open");

			byte[] data = new byte[8];

			data[0] = 1;
			data[1] = 2;
			data[2] = (byte)type;
			data[3] = (byte)val1;
			data[4] = (byte)val2;
			data[5] = (byte)val3;
			data[6] = (byte)val4;
			data[7] = CMD_END;


			return device.WriteFeatureData(data);
		}

		public bool SetMode(Mode mode) {
			if (!device.IsOpen)
				throw new Exception("Device not open");

			return SendData(SET_MODE, (int)mode, 0, 0, 0);
		}

		public bool SetColor(Region region, Color color, Level level) {
			if (!device.IsOpen)
				throw new Exception("Device not open");

			return SendData(SET_REGION_COLOR, (int)region, (int)color, (int)level, 0);
		}

		public void TurnOff() {
			if (!device.IsOpen)
				return;

			SetColor(Region.LEFT, Color.OFF, Level.HIGH);
			SetColor(Region.CENTER, Color.OFF, Level.HIGH);
			SetColor(Region.RIGHT, Color.OFF, Level.HIGH);
			SetMode(Mode.NORMAL);
		}
	}
}
