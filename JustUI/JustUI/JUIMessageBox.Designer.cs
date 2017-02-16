using System.Drawing;
using System.Windows.Forms;

namespace JustUI {
	partial class JUIMessageBox {
		private TextBox CONTENT;		
		private JUIButton OK;
		private JUIButton NO;
		private void InitializeComponent(int h = 300, int w = 200)
		{
			// 
			// Controls initialization
			//
			CONTENT = new TextBox();
			OK = new JUIButton();
			NO = new JUIButton();
			// 
			// JUIMessageBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "JustUIMessageBox";
			this.Width = w;
			this.Height = h;
			AeroCheck();
			Size = new Size(h, w);
			StartPosition = FormStartPosition.CenterScreen;
			KeyDown += (o, e) => {
				switch ((Keys)e.KeyCode) {
					case Keys.Enter:
						OK.PerformClick();
						break;
					case Keys.Escape:
						X.PerformClick();
						break;
				}
			};
			// OK Button properties.
			OK.Text = "Yes";
			OK.DialogResult = DialogResult.OK;
			OK.SetColors(1);
			NO.Text = "No";
			NO.DialogResult = X.DialogResult = DialogResult.No;
			NO.SetColors(2);
			// Message box Title(Caption) properties.
			TITLE.Text = "---";
			// Message box content properties.
			CONTENT.Text = "...\r\n......";
			CONTENT.BorderStyle = BorderStyle.None;
			CONTENT.Font = new Font("Segoe UI Symbol", 10);
			CONTENT.ReadOnly = true;
			CONTENT.TabStop = false;
			CONTENT.HideSelection = true;
			CONTENT.Cursor = Cursors.Arrow;
			CONTENT.Multiline = true;
			CONTENT.BackColor = this.BackColor;
			// Add the controls to form.
			Controls.Add(CONTENT);
			Controls.AddRange(new []{ OK, NO });
		}
	}
}
