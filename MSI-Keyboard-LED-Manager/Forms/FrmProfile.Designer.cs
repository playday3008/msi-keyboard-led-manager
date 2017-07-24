namespace MSI_Keyboard_LED_Manager.Forms {
	partial class FrmProfile {
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
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.num_time = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.group_modes = new System.Windows.Forms.GroupBox();
			this.radio_mode_rainbow = new System.Windows.Forms.RadioButton();
			this.radio_mode_audio2 = new System.Windows.Forms.RadioButton();
			this.radio_mode_wave = new System.Windows.Forms.RadioButton();
			this.radio_mode_audio = new System.Windows.Forms.RadioButton();
			this.radio_mode_breath = new System.Windows.Forms.RadioButton();
			this.radio_mode_gaming = new System.Windows.Forms.RadioButton();
			this.radio_mode_normal = new System.Windows.Forms.RadioButton();
			this.btn1_left = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn1_center = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btn1_right = new System.Windows.Forms.Button();
			this.btn2_left = new System.Windows.Forms.Button();
			this.btn2_right = new System.Windows.Forms.Button();
			this.btn2_center = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.num_time)).BeginInit();
			this.group_modes.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(429, 8);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(70, 22);
			this.btn_cancel.TabIndex = 26;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(353, 8);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(70, 22);
			this.btn_save.TabIndex = 25;
			this.btn_save.Text = "Save";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(88, 9);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(259, 20);
			this.txt_name.TabIndex = 24;
			this.txt_name.TextChanged += new System.EventHandler(this.changeHandler);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 12);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 13);
			this.label8.TabIndex = 23;
			this.label8.Text = "Profile name";
			// 
			// num_time
			// 
			this.num_time.Location = new System.Drawing.Point(363, 122);
			this.num_time.Name = "num_time";
			this.num_time.Size = new System.Drawing.Size(120, 20);
			this.num_time.TabIndex = 22;
			this.num_time.ValueChanged += new System.EventHandler(this.changeHandler);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(352, 100);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(140, 13);
			this.label7.TabIndex = 21;
			this.label7.Text = "Time between changes (ms)";
			// 
			// group_modes
			// 
			this.group_modes.Controls.Add(this.radio_mode_rainbow);
			this.group_modes.Controls.Add(this.radio_mode_audio2);
			this.group_modes.Controls.Add(this.radio_mode_wave);
			this.group_modes.Controls.Add(this.radio_mode_audio);
			this.group_modes.Controls.Add(this.radio_mode_breath);
			this.group_modes.Controls.Add(this.radio_mode_gaming);
			this.group_modes.Controls.Add(this.radio_mode_normal);
			this.group_modes.Location = new System.Drawing.Point(12, 35);
			this.group_modes.Name = "group_modes";
			this.group_modes.Size = new System.Drawing.Size(487, 53);
			this.group_modes.TabIndex = 17;
			this.group_modes.TabStop = false;
			this.group_modes.Text = "Mode";
			// 
			// radio_mode_rainbow
			// 
			this.radio_mode_rainbow.AutoSize = true;
			this.radio_mode_rainbow.Location = new System.Drawing.Point(413, 23);
			this.radio_mode_rainbow.Name = "radio_mode_rainbow";
			this.radio_mode_rainbow.Size = new System.Drawing.Size(67, 17);
			this.radio_mode_rainbow.TabIndex = 7;
			this.radio_mode_rainbow.TabStop = true;
			this.radio_mode_rainbow.Text = "Rainbow";
			this.radio_mode_rainbow.UseVisualStyleBackColor = true;
			this.radio_mode_rainbow.CheckedChanged += new System.EventHandler(this.changeHandler);
			// 
			// radio_mode_audio2
			// 
			this.radio_mode_audio2.AutoSize = true;
			this.radio_mode_audio2.Location = new System.Drawing.Point(340, 23);
			this.radio_mode_audio2.Name = "radio_mode_audio2";
			this.radio_mode_audio2.Size = new System.Drawing.Size(67, 17);
			this.radio_mode_audio2.TabIndex = 6;
			this.radio_mode_audio2.TabStop = true;
			this.radio_mode_audio2.Text = "Audio v2";
			this.radio_mode_audio2.UseVisualStyleBackColor = true;
			this.radio_mode_audio2.CheckedChanged += new System.EventHandler(this.changeHandler);
			// 
			// radio_mode_wave
			// 
			this.radio_mode_wave.AutoSize = true;
			this.radio_mode_wave.Location = new System.Drawing.Point(280, 23);
			this.radio_mode_wave.Name = "radio_mode_wave";
			this.radio_mode_wave.Size = new System.Drawing.Size(54, 17);
			this.radio_mode_wave.TabIndex = 5;
			this.radio_mode_wave.TabStop = true;
			this.radio_mode_wave.Text = "Wave";
			this.radio_mode_wave.UseVisualStyleBackColor = true;
			this.radio_mode_wave.CheckedChanged += new System.EventHandler(this.changeHandler);
			// 
			// radio_mode_audio
			// 
			this.radio_mode_audio.AutoSize = true;
			this.radio_mode_audio.Location = new System.Drawing.Point(225, 23);
			this.radio_mode_audio.Name = "radio_mode_audio";
			this.radio_mode_audio.Size = new System.Drawing.Size(52, 17);
			this.radio_mode_audio.TabIndex = 4;
			this.radio_mode_audio.TabStop = true;
			this.radio_mode_audio.Text = "Audio";
			this.radio_mode_audio.UseVisualStyleBackColor = true;
			this.radio_mode_audio.CheckedChanged += new System.EventHandler(this.changeHandler);
			// 
			// radio_mode_breath
			// 
			this.radio_mode_breath.AutoSize = true;
			this.radio_mode_breath.Location = new System.Drawing.Point(149, 23);
			this.radio_mode_breath.Name = "radio_mode_breath";
			this.radio_mode_breath.Size = new System.Drawing.Size(70, 17);
			this.radio_mode_breath.TabIndex = 3;
			this.radio_mode_breath.TabStop = true;
			this.radio_mode_breath.Text = "Breathing";
			this.radio_mode_breath.UseVisualStyleBackColor = true;
			this.radio_mode_breath.CheckedChanged += new System.EventHandler(this.changeHandler);
			// 
			// radio_mode_gaming
			// 
			this.radio_mode_gaming.AutoSize = true;
			this.radio_mode_gaming.Location = new System.Drawing.Point(82, 23);
			this.radio_mode_gaming.Name = "radio_mode_gaming";
			this.radio_mode_gaming.Size = new System.Drawing.Size(61, 17);
			this.radio_mode_gaming.TabIndex = 2;
			this.radio_mode_gaming.TabStop = true;
			this.radio_mode_gaming.Text = "Gaming";
			this.radio_mode_gaming.UseVisualStyleBackColor = true;
			this.radio_mode_gaming.CheckedChanged += new System.EventHandler(this.changeHandler);
			// 
			// radio_mode_normal
			// 
			this.radio_mode_normal.AutoSize = true;
			this.radio_mode_normal.Location = new System.Drawing.Point(18, 23);
			this.radio_mode_normal.Name = "radio_mode_normal";
			this.radio_mode_normal.Size = new System.Drawing.Size(58, 17);
			this.radio_mode_normal.TabIndex = 1;
			this.radio_mode_normal.TabStop = true;
			this.radio_mode_normal.Text = "Normal";
			this.radio_mode_normal.UseVisualStyleBackColor = true;
			this.radio_mode_normal.CheckedChanged += new System.EventHandler(this.changeHandler);
			// 
			// btn1_left
			// 
			this.btn1_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btn1_left.Location = new System.Drawing.Point(6, 19);
			this.btn1_left.Name = "btn1_left";
			this.btn1_left.Size = new System.Drawing.Size(42, 29);
			this.btn1_left.TabIndex = 28;
			this.btn1_left.UseVisualStyleBackColor = false;
			this.btn1_left.Click += new System.EventHandler(this.btn_color_handler);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn2_left);
			this.groupBox1.Controls.Add(this.btn1_left);
			this.groupBox1.Location = new System.Drawing.Point(12, 94);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(105, 54);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Left";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn2_center);
			this.groupBox2.Controls.Add(this.btn1_center);
			this.groupBox2.Location = new System.Drawing.Point(123, 94);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(105, 54);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Center";
			// 
			// btn1_center
			// 
			this.btn1_center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btn1_center.Location = new System.Drawing.Point(6, 19);
			this.btn1_center.Name = "btn1_center";
			this.btn1_center.Size = new System.Drawing.Size(42, 29);
			this.btn1_center.TabIndex = 28;
			this.btn1_center.UseVisualStyleBackColor = false;
			this.btn1_center.Click += new System.EventHandler(this.btn_color_handler);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btn2_right);
			this.groupBox3.Controls.Add(this.btn1_right);
			this.groupBox3.Location = new System.Drawing.Point(234, 94);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(105, 54);
			this.groupBox3.TabIndex = 33;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Right";
			// 
			// btn1_right
			// 
			this.btn1_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btn1_right.Location = new System.Drawing.Point(6, 19);
			this.btn1_right.Name = "btn1_right";
			this.btn1_right.Size = new System.Drawing.Size(42, 29);
			this.btn1_right.TabIndex = 28;
			this.btn1_right.UseVisualStyleBackColor = false;
			this.btn1_right.Click += new System.EventHandler(this.btn_color_handler);
			// 
			// btn2_left
			// 
			this.btn2_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btn2_left.Location = new System.Drawing.Point(57, 19);
			this.btn2_left.Name = "btn2_left";
			this.btn2_left.Size = new System.Drawing.Size(42, 29);
			this.btn2_left.TabIndex = 29;
			this.btn2_left.UseVisualStyleBackColor = false;
			this.btn2_left.Click += new System.EventHandler(this.btn_color_handler);
			// 
			// btn2_right
			// 
			this.btn2_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btn2_right.Location = new System.Drawing.Point(58, 19);
			this.btn2_right.Name = "btn2_right";
			this.btn2_right.Size = new System.Drawing.Size(42, 29);
			this.btn2_right.TabIndex = 29;
			this.btn2_right.UseVisualStyleBackColor = false;
			this.btn2_right.Click += new System.EventHandler(this.btn_color_handler);
			// 
			// btn2_center
			// 
			this.btn2_center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btn2_center.Location = new System.Drawing.Point(57, 19);
			this.btn2_center.Name = "btn2_center";
			this.btn2_center.Size = new System.Drawing.Size(42, 29);
			this.btn2_center.TabIndex = 29;
			this.btn2_center.UseVisualStyleBackColor = false;
			this.btn2_center.Click += new System.EventHandler(this.btn_color_handler);
			// 
			// FrmProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 155);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.num_time);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.group_modes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmProfile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FrmProfile";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProfile_FormClosing);
			this.Load += new System.EventHandler(this.FrmProfile_Load);
			((System.ComponentModel.ISupportInitialize)(this.num_time)).EndInit();
			this.group_modes.ResumeLayout(false);
			this.group_modes.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown num_time;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox group_modes;
		private System.Windows.Forms.RadioButton radio_mode_rainbow;
		private System.Windows.Forms.RadioButton radio_mode_audio2;
		private System.Windows.Forms.RadioButton radio_mode_wave;
		private System.Windows.Forms.RadioButton radio_mode_audio;
		private System.Windows.Forms.RadioButton radio_mode_breath;
		private System.Windows.Forms.RadioButton radio_mode_gaming;
		private System.Windows.Forms.RadioButton radio_mode_normal;
		private System.Windows.Forms.Button btn1_left;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btn1_center;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btn1_right;
		private System.Windows.Forms.Button btn2_left;
		private System.Windows.Forms.Button btn2_center;
		private System.Windows.Forms.Button btn2_right;
	}
}