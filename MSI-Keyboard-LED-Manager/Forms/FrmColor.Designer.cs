namespace MSI_Keyboard_LED_Manager.Forms {
	partial class FrmColor {
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
			this.SuspendLayout();
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(95, 214);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_cancel.TabIndex = 0;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// FrmColor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(248, 248);
			this.Controls.Add(this.btn_cancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmColor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Pick a Color";
			this.Load += new System.EventHandler(this.FrmColor_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_cancel;
	}
}