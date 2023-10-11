using System;
using System.Linq;
using System.Windows.Forms;

namespace NaoParse
{
	public static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			var providerArg = args.FirstOrDefault(a => a.StartsWith("provider="));
			var providerName = "mod_alissa";
			if (!string.IsNullOrEmpty(providerArg))
			{
				providerName = providerArg.Substring(9).Trim();
			}
			Console.WriteLine($"providerName: {providerName}");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmDpsMeter(providerName));
		}
	}
}
