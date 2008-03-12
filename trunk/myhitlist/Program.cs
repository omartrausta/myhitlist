using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace myhitlist
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
        /// prufa check oli aftur
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}