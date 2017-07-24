using MSI_Keyboard_LED_Manager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSI_Keyboard_LED_Manager.Forms {
	public partial class FrmProfile : Form {
		public Profile profile = null;

		bool supposedToClose = false;
		bool loaded = false;
		bool changed = false;

		public FrmProfile() {
			InitializeComponent();
		}

		public Profile Create() {
			this.Text = "Create a profile";

			profile = new Profile();
			loadControlsFromProfile(profile);

			loaded = true;
			changed = true;

			this.ShowDialog();

			return profile;
		}

		public Profile Edit(Profile p) {
			this.Text = "Edit profile - " + p.name;
			profile = p;

			loadControlsFromProfile(p);

			loaded = true;

			this.ShowDialog();

			return profile;
		}

		private void FrmProfile_Load(object sender, EventArgs e) {
			Icon = Properties.Resources.icon_normal;
		}

		private void btn_save_Click(object sender, EventArgs e) {
			loadProfileFromControls();

			if (txt_name.Text.Equals(""))
				MessageBox.Show("The name can't be empty!", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else {
				supposedToClose = true;
				this.Close();
			}
		}

		private void btn_cancel_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void loadControlsFromProfile(Profile p) {
			// Mode
			switch (profile.mode) {
				case Keyboard.Mode.NORMAL:
					radio_mode_normal.Checked = true;
					break;
				case Keyboard.Mode.GAMING:
					radio_mode_gaming.Checked = true;
					break;
				case Keyboard.Mode.BREATH:
					radio_mode_breath.Checked = true;
					break;
				case Keyboard.Mode.AUDIO:
					radio_mode_audio.Checked = true;
					break;
				case Keyboard.Mode.WAVE:
					radio_mode_wave.Checked = true;
					break;
				case Keyboard.Mode.AUDIO2:
					radio_mode_audio2.Checked = true;
					break;
				case Keyboard.Mode.RAINBOW:
					radio_mode_rainbow.Checked = true;
					break;
				default:
					radio_mode_normal.Checked = true;
					break;
			}

			// Name and time
			txt_name.Text = profile.name;
			num_time.Value = profile.delay;

			btn1_left.BackColor = profile.color1[0].rgb;
			btn1_center.BackColor = profile.color1[1].rgb;
			btn1_right.BackColor = profile.color1[2].rgb;

			btn2_left.BackColor = profile.color2[0].rgb;
			btn2_center.BackColor = profile.color2[1].rgb;
			btn2_right.BackColor = profile.color2[2].rgb;
		}

		private void loadProfileFromControls() {
			if (profile == null)
				return;

			// Name
			profile.name = txt_name.Text;

			// Delay
			profile.delay = Decimal.ToInt32(num_time.Value);

			// Colors
			profile.color1[0] = Profile.ColorLevel.FromRGB(btn1_left.BackColor);
			profile.color1[1] = Profile.ColorLevel.FromRGB(btn1_center.BackColor);
			profile.color1[2] = Profile.ColorLevel.FromRGB(btn1_right.BackColor);

			profile.color2[0] = Profile.ColorLevel.FromRGB(btn2_left.BackColor);
			profile.color2[1] = Profile.ColorLevel.FromRGB(btn2_center.BackColor);
			profile.color2[2] = Profile.ColorLevel.FromRGB(btn2_right.BackColor);

			// Mode
			int tmp_mode = 0;

			if (radio_mode_normal.Checked)
				tmp_mode = 1;
			else if (radio_mode_gaming.Checked)
				tmp_mode = 2;
			else if (radio_mode_breath.Checked)
				tmp_mode = 3;
			else if (radio_mode_audio.Checked)
				tmp_mode = 4;
			else if (radio_mode_wave.Checked)
				tmp_mode = 5;
			else if (radio_mode_audio2.Checked)
				tmp_mode = 6;
			else if (radio_mode_rainbow.Checked)
				tmp_mode = 7;

			profile.mode = (Keyboard.Mode)tmp_mode;
		}

		private void FrmProfile_FormClosing(object sender, FormClosingEventArgs e) {
			if(!supposedToClose && changed) {
				DialogResult res = MessageBox.Show("Are you sure you want to close? Your changes will not be saved.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (res == DialogResult.No)
					e.Cancel = true;
				else
					profile = null;
			}

			if(!e.Cancel) {
				loaded = false;
				Program.tempProfile = null;
				Program.Update();
			}
		}

		private void changeHandler(object sender, EventArgs e) {
			if(loaded) {
				loadProfileFromControls();
				if(sender != txt_name) {
					Program.tempProfile = profile;
					Program.Update();
				}
				changed = true;
			}
		}

		private void btn_color_handler(object sender, EventArgs e) {
			FrmColor frmColor = new FrmColor();
			Color c = frmColor.chooseColor();

			if(c != Color.Transparent) {
				((Button)sender).BackColor = c;
				changeHandler(sender, e);
			}
		}
	}
}
