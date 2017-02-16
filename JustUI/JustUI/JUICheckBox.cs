using System;
using System.Drawing;
using System.Windows.Forms;

namespace JustUI {
	public partial class JUICheckBox : CheckBox {
		const string checked_img = @"iVBORw0KGgoAAAANSUhEUgAAAA0AAAANCAIAAAD9iXMrAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8
YQUAAAAbSURBVChTY3AgDoDU/ScERtVhBwOsjjBwcAAA5PmNpcrRjYMAAAAASUVORK5CYII=";
		const string unchecked_img = @"iVBORw0KGgoAAAANSUhEUgAAAA0AAAANCAIAAAD9iXMrAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8
YQUAAAAadEVYdFNvZnR3YXJlAFBpeEJ1aWxkZXIgU3R1ZGlvxVl2OwAAAEZJREFUKFO9zEEOABAMRFFH
600cx7GZRoKORtn46Ub7Isld6mrUZ5eLDjq5gdB06xbR0/w3boSQcagLQogd2hFynNujixNpRkl8JScw
9DIAAAAASUVORK5CYII=";
		public JUICheckBox() {
			this.FlatStyle = FlatStyle.Flat;
		}
		Image Base64ToImage(string base64) {
			byte[] imageBytes = Convert.FromBase64String(base64);
			using (var ms = new System.IO.MemoryStream(imageBytes, 0, imageBytes.Length)) {
				return Image.FromStream(ms, true);
			}
		} 
		protected override void OnPaint(PaintEventArgs e) {
			base.OnPaint(e);
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			var rc = this.ClientRectangle;
			var g = e.Graphics;
			var textSize = TextRenderer.MeasureText(Text, Font);
			var top = (Height + textSize.Height) / 2 - textSize.Height + 1;				
			if (Checked)
				g.DrawImage(Base64ToImage(checked_img), new PointF(0, top));
			else 
				g.DrawImage(Base64ToImage(unchecked_img), new PointF(0, top));
		}
	}
	
}
