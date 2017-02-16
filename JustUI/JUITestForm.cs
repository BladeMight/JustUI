using System;

namespace JustUI_Test
{
	
	public partial class JUITestForm : JustUI.JUIForm
	{
		public JUITestForm()
		{
			InitializeComponent();
			this.juiButton1.SetColors(1);
			this.juiButton2.SetColors(2);
		}
	}
}
