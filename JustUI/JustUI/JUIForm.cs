using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JustUI
{
	public partial class JUIForm : Form {
		public bool AeroEnabled = true;
		public JUIForm() {
			AeroCheck();
//			KeyDown += (o, e) => {
//				switch ((Keys)e.KeyCode) {
//					case Keys.Enter:
//						OK.PerformClick();
//						break;
//					case Keys.Escape:
//						X.PerformClick();
//						break;
//				}
//			};
			InitializeComponent();
		}
		#region Functions
		public void AeroCheck() {
		//Check if Aero is avaible.
		if (Environment.OSVersion.Version.Major >= 6) {
			int enabled = 0;
			DwmIsCompositionEnabled(ref enabled);
			//Check if Aero is enabled.
			AeroEnabled = (enabled == 1);
			}
		}
		/// <summary>
		/// Gets the Aero color. 
		/// </summary>
		/// <returns>Aero color as Color.</returns>
		Color CurrentAeroColor() {
			DWM_COLORIZATION_PARAMS parameters;
			DwmGetColorizationParameters(out parameters);
			return Color.FromArgb(Int32.Parse(parameters.clrColor.ToString("X"), System.Globalization.NumberStyles.HexNumber));;
		}
		#endregion
		#region Overridings
		protected override void OnShown(EventArgs e) {
			this.SuspendLayout();
			TITLE.Location = new Point(1, 1);
			X.Location = new Point(Width - 24, 1);
			_.Location = new Point(Width - 24 - X.Width, 1);
			TITLE.Width = Width - 1 - X.Width - 1 - _.Width;
			this.ResumeLayout(false);
			base.OnShown(e);
		}
		protected override void WndProc(ref Message m) {
			// Adds shadow to message box, on WM_NCPAIN message if Aero enabled. 
			const int WM_NCPAINT = 0x0085;
			if (m.Msg == WM_NCPAINT && AeroEnabled) {
				var v = 2;
				DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
				var margins = new MARGINS(){ bH = 1, lW = 1, rW = 1, tH = 1 };
				DwmExtendFrameIntoClientArea(this.Handle, ref margins);
			}
			base.WndProc(ref m);
		}
		protected override void OnPaint(PaintEventArgs e) {
			//Draws rectangle on all form, using Aero color, or Active border if it is disabled.
			Graphics g = CreateGraphics();
			var pn = new Pen(CurrentAeroColor());
			if (!AeroEnabled)
				pn.Color = Color.FromKnownColor(KnownColor.LightGray);
			g.DrawRectangle(pn, new Rectangle(0, 0, Size.Width - 1, Size.Height - 1));
			g.Dispose();
			pn.Dispose();
			base.OnPaint(e);
		}
		#endregion
		#region DLL imports & custom structs
		struct MARGINS {
			public int lW;
			public int rW;
			public int tH;
			public int bH;
		}
		struct DWM_COLORIZATION_PARAMS {
			public uint clrColor;
			public uint clrAfterGlow;
			public uint nIntensity;
			public uint clrAfterGlowBalance;
			public uint clrBlurBalance;
			public uint clrGlassReflectionIntensity;
			public bool fOpaque;
		}
		[DllImport("dwmapi.dll")]
		static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
	    [DllImport("dwmapi.dll", EntryPoint = "#127", PreserveSig = false)]
	    static extern void DwmGetColorizationParameters(out DWM_COLORIZATION_PARAMS parameters);
		[DllImport("dwmapi.dll")]
		static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
		[DllImport("dwmapi.dll")]
		static extern int DwmIsCompositionEnabled(ref int pfEnabled);
		#endregion
	}
}
