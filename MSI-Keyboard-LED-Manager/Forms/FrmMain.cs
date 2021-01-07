using MSI_Keyboard_LED_Manager.Classes;
using MSI_Keyboard_LED_Manager.Forms;
using System;
using System.Windows.Forms;

namespace MSI_Keyboard_LED_Manager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Opacity = 0;

            TrayIcon.Icon = Config.enabled ? Properties.Resources.icon_normal : Properties.Resources.icon_gray;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
        }

        private void enabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config.enabled = !enabledToolStripMenuItem.Checked;
            Config.Save();

            Program.Update();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            Hide();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            TrayIcon.Visible = false;
        }

        private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                enabledToolStripMenuItem.Checked = Config.enabled;

                profilesToolStripMenuItem.DropDownItems.Clear();

                if (Program.profiles.Count != 0)
                {
                    for (int i = 0; i < Program.profiles.Count; i++)
                    {
                        ToolStripMenuItem temp_item = new ToolStripMenuItem
                        {
                            Name = "profileMenuItem_" + i,
                            Text = Program.profiles[i].name
                        };
                        temp_item.Click += new EventHandler(ProfileChange);

                        if (i == Config.selectedProfile)
                        {
                            temp_item.Checked = true;
                        }

                        profilesToolStripMenuItem.DropDownItems.Add(temp_item);
                    }
                }
                else
                {
                    ToolStripMenuItem temp_item = new ToolStripMenuItem
                    {
                        Name = "no_profiles",
                        Text = "No profiles",
                        Enabled = false
                    };
                    profilesToolStripMenuItem.DropDownItems.Add(temp_item);
                }
            }
        }

        private void ProfileChange(object sender, EventArgs e)
        {
            Config.selectedProfile = int.Parse(((ToolStripMenuItem)sender).Name.Replace("profileMenuItem_", ""));
            Config.Save();
            Program.Update();
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            Config.enabled = !Config.enabled;
            Config.Save();
            Program.Update();

            TrayIcon.Icon = Config.enabled ? Properties.Resources.icon_normal : Properties.Resources.icon_gray;
        }

        private void TrayIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
