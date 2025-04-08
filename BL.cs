using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Eksamensprojekt
{

	public abstract class Spørgsmål
	{
		public string beskrivelse = "";
		public Image eksempelbillede = null;

		// Fra fil
		public virtual void IndlæsSpørgsmål(string fil)
		{
			using (StreamReader sr = new StreamReader(fil))
			{
				beskrivelse = sr.ReadLine();
				string billede_sti = sr.ReadLine();
				eksempelbillede = Image.FromFile(billede_sti);
				sr.Close();
			};
		}

		// Til fil
		public virtual void GemSpørgsmål(string fil, string billede_sti)
		{
			using (StreamWriter sw = new StreamWriter(fil))
			{
				sw.WriteLine(beskrivelse);
				sw.WriteLine(billede_sti);
				eksempelbillede.Save(billede_sti);
				sw.Close();
			};
		}
	}

	public class MultipleChoice : Spørgsmål
	{
		public string[] mulige_svar = { };
		private int korrekt;
		public int svar;

		public MultipleChoice() { }
		public MultipleChoice(string fil)
		{
			this.IndlæsSpørgsmål(fil);
		}

		override public void IndlæsSpørgsmål(string fil)
		{
			base.IndlæsSpørgsmål(fil);
			string[] data = beskrivelse.Split('#');
			beskrivelse = data[0];
			korrekt = int.Parse(data[1]);
			mulige_svar = data[2..];
		}

		public override void GemSpørgsmål(string fil, string billede_sti)
		{
			beskrivelse += '#' + korrekt;
			foreach (string mulighed in mulige_svar)
				beskrivelse += '#' + mulighed;
			base.GemSpørgsmål(fil + "#MC", billede_sti);
		}
	}

	file class ÅbentSvar : Spørgsmål
	{
		public string svar = "";

		public ÅbentSvar() { }
		public ÅbentSvar(string fil)
		{
			this.IndlæsSpørgsmål(fil);
		}
		public override void GemSpørgsmål(string fil, string billede_sti)
		{
			base.GemSpørgsmål(fil + "#ÅS", billede_sti);
		}
	}

	public class Opgave
	{
		public List<Spørgsmål> spørgsmål = new List<Spørgsmål>();
		public int index = 0;
		public bool indlæst = false;
		
		void IndlæsOpgave(string opgavesti)
		{
			if (!Directory.Exists(opgavesti))
				return;

			string[] spørgsmålsstier = Directory.GetFiles(opgavesti);
			foreach (string spørgsmålssti in spørgsmålsstier)
			{
				if (!File.Exists(spørgsmålssti))
					continue;

				if (spørgsmålssti.Contains("MC"))
					spørgsmål.Add(new MultipleChoice(spørgsmålssti));

				else if (spørgsmålssti.Contains("ÅS"))
					spørgsmål.Add(new ÅbentSvar(spørgsmålssti));

				else
					continue;
			}
		}

		// Returnerer næste spørgsmål eller null, hvis der ikke er flere
		Spørgsmål Næste()
		{
			if (index < spørgsmål.Count() - 1)
			{
				return spørgsmål[++index];
			}
			return null; // Der er ikke flere spørgsmål
		}

		Spørgsmål Forrige()
		{
			if (index > 0)
			{
				return spørgsmål[--index];
			}
			return null; // Der er ikke flere spørgsmål
		}

		// Hvor mange Spørgsmål har eleven svaret rigtigt på?
		int AntalRigtige()
		{
			return 0;
		}

		// Returnerer som decimaltal mellem 0 og 1
		float AndelRigtige()
		{
			return 0;
		}
	}

	internal static class BL
	{
		// Rækkefølge på array: brugernavn, adgangskode, rang
		public static List<string[]> brugere = new List<string[]>();

		// Opgaverne
		public static List<Opgave> alle_opgaver = new List<Opgave>();
		public static List<Opgave> besvarelser = new List<Opgave>();
		public static int opgaveindeks = 0;
		public static int sværhedsgrad = 0; // 0: Let, 1: Mellem, 2: Svær

		// Spørgsmålene
		public static List<Spørgsmål> spørgsmål = new List<Spørgsmål>();
		public static int spørgsmålsindeks = 0;

		// Data
		public static string data_sti = "";

		// -1: Ikke bruger, 0: Elev, 1: Lærer
		public static int ErBruger(string brugernavn, string adgangskode)
		{
			for (int i = 0; i < brugere.Count; i++)
			{
				if (brugere[i][0] != brugernavn || brugere[i][1] != adgangskode)
					continue;

				switch(brugere[i][2])
				{
					case "l":
						return 1;
					case "e":
						return 0;
				}
			}
			return -1;
		}
		
		// true: ny bruger blev oprettet, false: ingen bruger blev oprettet (findes allerede)
		public static bool OpretBruger(string brugernavn, string adgangskode)
		{
			//Tjekker om en bruger med samme brugernavn findes
			for (int i = 0; i < brugere.Count; i++)
			{   
				if (brugere[i][0] == brugernavn)
				{
					return false;            
				}
			}
			string[] bruger = { brugernavn, adgangskode, "e" };
			brugere.Add(bruger);
			return true;
		}

		public static void IndlæsData()
		{
			using StreamReader sr = new StreamReader(data_sti + "\\brugere");
			{
				string[] linjer = sr.ReadToEnd().Split("\r\n");

				foreach (string linje in linjer)
				{
					if (linje.Length < 5)
						continue;

					string[] værdier = linje.Split(' ');
					if (værdier.Length == 3)
						brugere.Add(værdier);
				}
			}

			string[] opgavestier = Directory.GetDirectories(data_sti + "\\Opgaver");
			foreach (string opgavesti in opgavestier)
			{
				Opgave ny_opgave = new Opgave();

				string[] spørgsmålsstier = Directory.GetFiles(opgavesti);
				foreach (string spørgsmålssti in spørgsmålsstier)
				{
					if (spørgsmålssti.Contains("MC"))
					{
						ny_opgave.spørgsmål.Add(new MultipleChoice(spørgsmålssti));
						continue;
					}

					if (spørgsmålssti.Contains("ÅS"))
					{
						ny_opgave.spørgsmål.Add(new ÅbentSvar(spørgsmålssti));
						continue;
					}
				}

				alle_opgaver.Add(ny_opgave);
			}
		}
	}
}
