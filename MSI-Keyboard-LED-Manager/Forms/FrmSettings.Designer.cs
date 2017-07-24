namespace MSI_Keyboard_LED_Manager.Forms {
	partial class FrmSettings {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
			this.btn_about = new System.Windows.Forms.Button();
			this.chk_startup = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_edit = new System.Windows.Forms.Button();
			this.btn_new = new System.Windows.Forms.Button();
			this.list_profiles = new System.Windows.Forms.ListBox();
			this.chk_screen = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_about
			// 
			this.btn_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_about.Location = new System.Drawing.Point(271, 243);
			this.btn_about.Name = "btn_about";
			this.btn_about.Size = new System.Drawing.Size(75, 23);
			this.btn_about.TabIndex = 5;
			this.btn_about.Text = "About";
			this.btn_about.UseVisualStyleBackColor = true;
			this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
			// 
			// chk_startup
			// 
			this.chk_startup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chk_startup.AutoSize = true;
			this.chk_startup.Location = new System.Drawing.Point(12, 235);
			this.chk_startup.Name = "chk_startup";
			this.chk_startup.Size = new System.Drawing.Size(129, 17);
			this.chk_startup.TabIndex = 4;
			this.chk_startup.Text = "Start when logging on";
			this.chk_startup.UseVisualStyleBackColor = true;
			this.chk_startup.CheckedChanged += new System.EventHandler(this.chk_startup_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btn_delete);
			this.groupBox1.Controls.Add(this.btn_edit);
			this.groupBox1.Controls.Add(this.btn_new);
			this.groupBox1.Controls.Add(this.list_profiles);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(334, 210);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Profiles";
			// 
			// btn_delete
			// 
			this.btn_delete.Image = global::MSI_Keyboard_LED_Manager.Properties.Resources.btn_delete;
			this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_delete.Location = new System.Drawing.Point(224, 19);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(98, 25);
			this.btn_delete.TabIndex = 3;
			this.btn_delete.Text = "Delete";
			this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_edit
			// 
			this.btn_edit.Image = global::MSI_Keyboard_LED_Manager.Properties.Resources.btn_edit;
			this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_edit.Location = new System.Drawing.Point(118, 19);
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(100, 25);
			this.btn_edit.TabIndex = 2;
			this.btn_edit.Text = "Edit";
			this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_edit.UseVisualStyleBackColor = true;
			this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
			// 
			// btn_new
			// 
			this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
			this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_new.Location = new System.Drawing.Point(12, 19);
			this.btn_new.Name = "btn_new";
			this.btn_new.Size = new System.Drawing.Size(100, 25);
			this.btn_new.TabIndex = 1;
			this.btn_new.Text = "New";
			this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_new.UseVisualStyleBackColor = true;
			this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
			// 
			// list_profiles
			// 
			this.list_profiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.list_profiles.FormattingEnabled = true;
			this.list_profiles.Location = new System.Drawing.Point(12, 50);
			this.list_profiles.Name = "list_profiles";
			this.list_profiles.Size = new System.Drawing.Size(310, 147);
			this.list_profiles.TabIndex = 0;
			this.list_profiles.DoubleClick += new System.EventHandler(this.list_profiles_DoubleClick);
			// 
			// chk_screen
			// 
			this.chk_screen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chk_screen.AutoSize = true;
			this.chk_screen.Location = new System.Drawing.Point(12, 258);
			this.chk_screen.Name = "chk_screen";
			this.chk_screen.Size = new System.Drawing.Size(142, 17);
			this.chk_screen.TabIndex = 6;
			this.chk_screen.Text = "Turn off when screen off";
			this.chk_screen.UseVisualStyleBackColor = true;
			this.chk_screen.CheckedChanged += new System.EventHandler(this.chk_screen_CheckedChanged);
			// 
			// FrmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 287);
			this.Controls.Add(this.chk_screen);
			this.Controls.Add(this.btn_about);
			this.Controls.Add(this.chk_startup);
			this.Controls.Add(this.groupBox1);
			this.MinimumSize = new System.Drawing.Size(370, 322);
			this.Name = "FrmSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MSI Keyboard LED Manager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
			this.Load += new System.EventHandler(this.FrmSettings_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_about;
		private System.Windows.Forms.CheckBox chk_startup;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_edit;
		private System.Windows.Forms.Button btn_new;
		private System.Windows.Forms.ListBox list_profiles;
		private System.Windows.Forms.CheckBox chk_screen;
	}
}