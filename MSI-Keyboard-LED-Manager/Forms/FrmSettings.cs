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
	public partial class FrmSettings : Form {
		public FrmSettings() {
			InitializeComponent();
		}

		private void FrmSettings_Load(object sender, EventArgs e) {
			this.Icon = Properties.Resources.icon_normal;
			chk_startup.Checked = Startup.Check();
			chk_screen.Checked = Config.onScreenOff;

			ReloadProfiles();
		}

		private void chk_startup_CheckedChanged(object sender, EventArgs e) {
			if (chk_startup.Checked)
				Startup.Add();
			else
				Startup.Remove();
		}

		private void chk_screen_CheckedChanged(object sender, EventArgs e) {
			Config.onScreenOff = chk_screen.Checked;
			Config.Save();
		}

		private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e) {

		}

		private void btn_about_Click(object sender, EventArgs e) {
			MessageBox.Show("Made by José Rebelo\n\nUses HidLibrary and NAudio.\nBased on MSI Keyboard LED Controller from wearefractal.", "About");
		}

		private void btn_new_Click(object sender, EventArgs e) {
			FrmProfile frmProfile = new FrmProfile();
			Profile p = frmProfile.Create();
			if (p != null) {
				Program.profiles.Add(p);
				Profile.Save(Program.profiles);
				Program.Update();
				ReloadProfiles();
				list_profiles.SelectedIndex = list_profiles.Items.Count - 1;
			}
		}

		private void btn_edit_Click(object sender, EventArgs e) {
			int idx = list_profiles.SelectedIndex;
			if (idx != -1) {
				FrmProfile frmProfile = new FrmProfile();

				Profile p = frmProfile.Edit(Program.profiles[idx]);

				if (p != null) {
					Program.profiles[idx] = p;
					Profile.Save(Program.profiles);
					Program.Update();
					ReloadProfiles();
					list_profiles.SelectedIndex = idx;
				}
			}
		}

		private void btn_delete_Click(object sender, EventArgs e) {
			int idx = list_profiles.SelectedIndex;
			if (idx != -1) {
				Program.profiles.RemoveAt(idx);
				Profile.Save(Program.profiles);
				ReloadProfiles();

				if (idx == Config.selectedProfile) {
					Config.selectedProfile--;
					Config.Save();
					Program.Update();
				}

				if (idx > 0)
					list_profiles.SelectedIndex = idx - 1;
				else if (list_profiles.Items.Count > 0)
					list_profiles.SelectedIndex = 0;
			}
		}

		private void ReloadProfiles() {
			list_profiles.Items.Clear();

			foreach (Profile p in Program.profiles)
				list_profiles.Items.Add(p.name);
		}

		private void list_profiles_DoubleClick(object sender, EventArgs e) {
			if (list_profiles.SelectedIndex >= 0) {
				Config.selectedProfile = list_profiles.SelectedIndex;
				Config.Save();
				Program.Update();
			}
		}
	}
}
