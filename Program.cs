namespace Eksamensprojekt
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			Form hoved_form = new Form();
			hoved_form.IsMdiContainer = true;

			ApplicationConfiguration.Initialize();
			Application.Run();
			
			// Åbn programmet
			hoved_form.Show();

			// Gå til log-in side
			Loginside logind = new Loginside();
			logind.MdiParent = hoved_form;
			logind.Show();
		}
	}
}