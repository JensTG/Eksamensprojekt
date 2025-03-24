namespace Eksamensprojekt
{
	internal static class Program
	{
		public static HovedForm hoved_form = new HovedForm();
		public static Opgave nuværende_opgave = new Opgave();

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]

        static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			hoved_form.IsMdiContainer = true;
			Application.Run(hoved_form);
		}
	}
}