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
	public partial class FrmColor : Form {
		public FrmColor() {
			InitializeComponent();
		}

		public Color chooseColor() {
			this.ShowDialog();

			return color;
		}

		public Color color = Color.Transparent;

		void OnColorSelection(object sender, EventArgs e) {
			Button btn = (Button)sender;
			String btn_color = btn.Name.Replace("btn_color_", "");
			color = ColorTranslator.FromHtml(btn_color);
			this.Close();
		}

		private void FrmColor_Load(object sender, EventArgs e) {
			this.Icon = Properties.Resources.icon_normal;

			// Create the buttons
			const int PER_ROW = 6;

			int x = 0;
			int y = 0;

			int size = 30;

			int spacing = 10;

			for (int i = 0; i < Profile.color_level.Count /* - 6*/; i++) {
				Button btn = new Button();
				btn.Name = "btn_color_" + Profile.color_level[i].ToString();
				btn.BackColor = Profile.color_level[i].rgb;
				btn.Text = "";
				btn.Location = new Point(spacing + x * (size + spacing), spacing + y * (size + spacing));
				btn.Size = new Size(size, size);
				x++;

				if (x >= PER_ROW) {
					x = 0;
					y++;
				}

				btn.Click += new EventHandler(OnColorSelection);

				this.Controls.Add(btn);
			}
		}

		private void btn_cancel_Click(object sender, EventArgs e) {
			color = Color.Transparent;
			this.Close();
		}
	}
}
