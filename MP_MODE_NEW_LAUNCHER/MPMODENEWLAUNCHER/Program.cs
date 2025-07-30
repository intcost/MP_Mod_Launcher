using System;
using System.Windows.Forms;

namespace MPMODENEWLAUNCHER
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MSCO());
		}
	}
}
