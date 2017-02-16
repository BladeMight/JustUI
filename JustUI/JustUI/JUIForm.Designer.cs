using System;
using System.Drawing;
using System.Windows.Forms;

namespace JustUI
{
	partial class JUIForm
	{
		public JUITitle TITLE;
		public JUIButton X;
		public JUIButton _;
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			//
			// Controls initialization
			//
			TITLE = new JUITitle();
			_ = new JUIButton();
			X = new JUIButton();
			// 
			// JUIForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "JUIForm";
			this.Name = "JUIForm";
			this.FormBorderStyle = FormBorderStyle.None;
			this.BackColor = Color.FromKnownColor(KnownColor.Window);
			this.ShowInTaskbar = true;
			this.Activated += (o, e) => { TITLE.Focus(); TITLE.Invalidate(); };
			this.Deactivate += (o, e) => { TITLE.Focus(); TITLE.Invalidate(); };
			//
			// Title & Min/Close buttons
			//
			X.Width = 23;
			X.Text = "X";
			X.TabStop = false;
			X.Click += (o, e) => this.Close();
			_.Width = 23;
			_.Text = "_";
			_.TabStop = false;
			_.Click += (o, e) => this.WindowState = FormWindowState.Minimized;
			X.SetColors(2);
			TITLE.Font = new Font("Segoe UI Bold", 12);
			//
			// Controls addings
			//
			this.Controls.Add(X);
			this.Controls.Add(_);
			this.Controls.Add(TITLE);
		}
	}
}
