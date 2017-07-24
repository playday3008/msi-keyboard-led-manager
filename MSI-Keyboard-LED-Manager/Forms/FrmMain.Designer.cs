namespace MSI_Keyboard_LED_Manager {
	partial class FrmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.profilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TimerUpdate = new System.Windows.Forms.Timer(this.components);
			this.TrayMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// TrayIcon
			// 
			this.TrayIcon.ContextMenuStrip = this.TrayMenu;
			this.TrayIcon.Text = "MSI Keyboard LED Manager";
			this.TrayIcon.Visible = true;
			this.TrayIcon.Click += new System.EventHandler(this.TrayIcon_Click);
			this.TrayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
			this.TrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
			// 
			// TrayMenu
			// 
			this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.enabledToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.TrayMenu.Name = "TrayMenu";
			this.TrayMenu.Size = new System.Drawing.Size(117, 92);
			// 
			// profilesToolStripMenuItem
			// 
			this.profilesToolStripMenuItem.Name = "profilesToolStripMenuItem";
			this.profilesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.profilesToolStripMenuItem.Text = "Profiles";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// enabledToolStripMenuItem
			// 
			this.enabledToolStripMenuItem.Checked = true;
			this.enabledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.enabledToolStripMenuItem.Name = "enabledToolStripMenuItem";
			this.enabledToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.enabledToolStripMenuItem.Text = "Enabled";
			this.enabledToolStripMenuItem.Click += new System.EventHandler(this.enabledToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 85);
			this.Name = "FrmMain";
			this.Text = "FrmMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.Shown += new System.EventHandler(this.FrmMain_Shown);
			this.TrayMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon TrayIcon;
		private System.Windows.Forms.ContextMenuStrip TrayMenu;
		private System.Windows.Forms.Timer TimerUpdate;
		private System.Windows.Forms.ToolStripMenuItem profilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enabledToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}

