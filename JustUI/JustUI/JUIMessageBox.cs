using System;
using System.Drawing;
using System.Windows.Forms;

namespace JustUI {
	public partial class JUIMessageBox : JUIForm {
		public JUIMessageBox(int h, int w) {
			InitializeComponent(h, w);
			Reposition();
		}
		/// <summary>
		/// Repositioning the controls on message box when size changed.
		/// </summary>
		public void Reposition()
		{
			OK.Location = new Point(1, Height - 24);
			NO.Location = new Point(Width - 24 - 52, Height - 24);
			X.Location = new Point(Width - 24, 1);
			_.Location = new Point(Width - 24 - X.Width, 1);
			TITLE.Location = new Point(1, 1);
			CONTENT.Location = new Point(1, TITLE.Height + 1);
		}
		/// <summary>
		/// Show dialog with title, content, type, align and sound.
		/// </summary>
		/// <param name="title">Title of message box.</param>
		/// <param name="content">Content of message box.</param>
		/// <param name="onlyOK">0 = YES/NO buttons, 1 = OK.</param>
		/// <param name="sound">Sound to be played when message box shows.</param>
		/// <returns>Dialog result Yes/No or OK(Yes)</returns>
		public DialogResult ShowDialog(string title, string content, bool onlyOK = false, System.Media.SystemSound sound = null)
		{
			TopMost = true;
			if (sound == null)
				sound = System.Media.SystemSounds.Beep;
			TITLE.Text = title;
			CONTENT.Text = content;
			Size tlinSize = TextRenderer.MeasureText(title, TITLE.Font);
			TITLE.Width = tlinSize.Width + 8;
			Size lineSize = TextRenderer.MeasureText(CONTENT.Text, CONTENT.Font);
			var captionWidth = 1 + TITLE.Width + X.Width + _.Width + 1;
			if (captionWidth < lineSize.Width)
				Width = lineSize.Width + 1;
			else
				Width = captionWidth;
			CONTENT.Height = lineSize.Height - CONTENT.Font.Height;
			CONTENT.Width = lineSize.Width - 1;
			Height = 1 + TITLE.Height + CONTENT.Height + OK.Height + 1;
			Reposition();
			if (onlyOK) {
				NO.Visible = false;
				OK.Text = "OK";
				OK.Location = new Point((Width - OK.Width) / 2, Height - 24);
			}
			TITLE.Width = Width - 1 - X.Width - 1 - _.Width;
			CONTENT.Width = Width - 2;
			sound.Play();
			return base.ShowDialog();
		}
	}
}
