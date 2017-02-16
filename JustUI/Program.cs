using System;
using System.Windows.Forms;
namespace JustUI_Test
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			var a = new JUITestForm();
			a.ShowDialog();
			var msgBox = new JustUI.JUIMessageBox(400, 200);
			msgBox.ShowDialog("I think its time to update!",
@"💎 Added new feature caret language display.
💎 Different colors/font for different layouts.
🐛 Fixed Update window height on different windows versions.
💬 Added more mouse-over tooltips.
💎 Updated LangDisplay class to support caretLangDisplay.
🎏 Fixed some translations.
📝 Finished XML documentation, now ALL Mahou functions have it.
📝 Moved color settings to TTipUI section in INI configuration.
📝 Other minor code improvements.", true, System.Media.SystemSounds.Exclamation);
			// TODO: Implement an Just UI combobox. 
		}
	}
}
