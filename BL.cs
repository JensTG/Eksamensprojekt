﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Eksamensprojekt
{

	public abstract class Spørgsmål
	{
		public string? beskrivelse = "";
		public Image? eksempelbillede = null;
		public string[] mulige_svar = { "", "", "", ""};

		public string korrekt = "";

		// Fra fil
		public virtual void IndlæsSpørgsmål(string fil)
		{
			using (StreamReader sr = new StreamReader(fil))
			{ 
				beskrivelse = sr.ReadLine();

				string? billedesti = sr.ReadLine();
				if (billedesti != null && File.Exists(billedesti))
					eksempelbillede = Image.FromFile(billedesti);
				sr.Close();
			};
		}

		// Til fil
		public virtual void GemSpørgsmål(string fil, string billedesti)
		{
			using (StreamWriter sw = new StreamWriter(fil))
			{
				sw.WriteLine(beskrivelse);

				if (eksempelbillede != null)
				{
					sw.WriteLine(billedesti);
					eksempelbillede.Save(billedesti);
				}
				sw.Close();
			};
		}
	}

	public class MultipleChoice : Spørgsmål
	{
		public MultipleChoice() { }
		public MultipleChoice(string[] mul, int korr)
		{
			mulige_svar = mul;
			korrekt = korr.ToString();
		}
		public MultipleChoice(string fil)
		{
			IndlæsSpørgsmål(fil);
		}

		override public void IndlæsSpørgsmål(string fil)
		{
			base.IndlæsSpørgsmål(fil);
			string[] data = beskrivelse.Split('#');
			beskrivelse = data[0];
			korrekt = data[1];
			mulige_svar = data[2..];
		}

		public override void GemSpørgsmål(string fil, string billedesti)
		{
			beskrivelse += '#' + korrekt;
			foreach (string mulighed in mulige_svar)
				beskrivelse += '#' + mulighed;
			base.GemSpørgsmål(fil + "-MC", billedesti);
		}
	}

	public class ÅbentSvar : Spørgsmål
	{
		public ÅbentSvar() { }

		public ÅbentSvar(string fil)
		{
			IndlæsSpørgsmål(fil);
		}
		public override void GemSpørgsmål(string fil, string billede_sti)
		{
			base.GemSpørgsmål(fil + "-ÅS", billede_sti);
		}
	}

	public class Opgave
	{
		public List<Spørgsmål> spørgsmål = new List<Spørgsmål>();
		public string titel = "";
		public string? beskrivelse;
		public Image? billede = null;

		public int index = 0;
		public bool indlæst = false;
		
		public void IndlæsOpgave(string opgavesti)
		{
			if (!Directory.Exists(opgavesti))
				return;

			string[] spørgsmålsstier = Directory.GetFiles(opgavesti);
			foreach (string spørgsmålssti in spørgsmålsstier)
			{
				if (!File.Exists(spørgsmålssti) || spørgsmålssti.Contains("meta"))
					continue;

				if (spørgsmålssti.Contains("MC"))
					spørgsmål.Add(new MultipleChoice(spørgsmålssti));

				else if (spørgsmålssti.Contains("ÅS"))
					spørgsmål.Add(new ÅbentSvar(spørgsmålssti));

				else
					continue;
			}

			// Indlæs meta-data om opgaven
			if (File.Exists(opgavesti + '\\' + "meta"))
			{
				using (StreamReader sr = new StreamReader(opgavesti + '\\' + "meta"))
				{
					titel = sr.ReadLine();
					beskrivelse = sr.ReadLine();

					string? billede_sti = sr.ReadLine();
					if (billede_sti != null && File.Exists(billede_sti))
						billede = Image.FromFile(billede_sti);
					sr.Close();
				};
			}
		}

		public void GemOpgave(string opgavesti)
		{
			string billedesti = "";
			Random rnd = new Random();

			if (Directory.Exists(opgavesti) && opgavesti.Length > 7) // For at være sikker
				Directory.Delete(opgavesti, true);

			Directory.CreateDirectory(opgavesti);

			for (int i = 0; i < spørgsmål.Count; i++)
			{
				do
				{
					billedesti = BL.data_sti + "\\billeder\\spm-" + rnd.NextInt64(1000).ToString("0000");
				} while (File.Exists(billedesti));
				spørgsmål[i].GemSpørgsmål(opgavesti + "\\" + i.ToString("000"), billedesti);
			}

            do
            {
                billedesti = BL.data_sti + "\\billeder\\opg-" + rnd.NextInt64(1000).ToString("0000");
            } while (File.Exists(billedesti));

            // Gem meta-data om opgaven
            using (StreamWriter sw = new StreamWriter(opgavesti + '\\' + "meta"))
			{
				sw.WriteLine(titel);
				sw.WriteLine(beskrivelse);

				if (billede != null)
				{
					sw.WriteLine(billedesti);
					billede.Save(billedesti);
				}

				sw.Close();
			};
		}


		// Returnerer næste spørgsmål eller null, hvis der ikke er flere
		Spørgsmål? Næste()
		{
			if (index < spørgsmål.Count() - 1)
			{
				return spørgsmål[++index];
			}
			return null; // Der er ikke flere spørgsmål
		}

		Spørgsmål? Forrige()
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
		public static string brugernavn = "";

		// Opgaverne
		public static List<Opgave> opgaver = new List<Opgave>();
		public static int opg_idx = 0;
		public static int sværhedsgrad = 0; // 0: Let, 1: Mellem, 2: Svær

		// Spørgsmålene
		public static List<Spørgsmål> spørgsmål = new List<Spørgsmål>();
		public static int spm_idx = 0;
		public static List<string> besvarelser = new List<string>(); // Opgavens titel # spørgsmål nr

		// Data
		public static string data_sti = "";

		// -1: Ikke bruger, 0: Elev, 1: Lærer
		public static int ErBruger(string brugernavn, string adgangskode)
		{
			for (int i = 0; i < brugere.Count; i++)
			{
				if (brugere[i][0] != brugernavn || brugere[i][1] != adgangskode)
					continue;

                BL.brugernavn = brugernavn;

                switch (brugere[i][2])
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
            BL.brugernavn = brugernavn;

			StreamWriter sw = File.AppendText(data_sti + '\\' + "brugere");
			sw.Write("\r\n" + brugernavn + ' ' + adgangskode + " e");
			sw.Close();

            return true;
		}

		public static void IndlæsData()
		{
			StreamReader sr = new StreamReader(data_sti + "\\brugere");
			string[] linjer = sr.ReadToEnd().Split("\r\n");

			foreach (string linje in linjer)
			{
				if (linje.Length < 5)
					continue;

				string[] værdier = linje.Split(' ');
				if (værdier.Length == 3)
					brugere.Add(værdier);
			}

            string[] opgavestier = Directory.GetDirectories(data_sti + "\\Opgaver");
			foreach (string opgavesti in opgavestier)
			{
				Opgave ny_opgave = new Opgave();
				ny_opgave.IndlæsOpgave(opgavesti);

				opgaver.Add(ny_opgave);
			}

			sr.Close();
			sr.Dispose();
        }

		public static void IndlæsBesvarelser()
		{
            if (File.Exists(data_sti + "\\Besvarelser\\" + brugernavn))
			{ 
                StreamReader sr = new StreamReader(data_sti + "\\Besvarelser\\" + brugernavn);
                besvarelser.Clear();
                besvarelser.AddRange(sr.ReadToEnd().Split("\r\n"));
            }
        }

		public static void GemData()
		{
			if (opgaver.Count == 0 || brugere.Count == 0)
				return;

			if (Directory.Exists(data_sti + "\\Opgaver"))
				Directory.Delete(data_sti + "\\Opgaver", true);
			Directory.CreateDirectory(data_sti + "\\Opgaver");

			if (!Directory.Exists(data_sti + "\\Besvarelser"))
				Directory.CreateDirectory(data_sti + "\\Besvarelser");

            foreach (Opgave opgave in opgaver)
			{
				opgave.GemOpgave(data_sti + "\\Opgaver\\" + opgave.titel);
			}

			if (besvarelser.Count != 0)
			{
                StreamWriter sw = new StreamWriter(data_sti + "\\Besvarelser\\" + brugernavn);
				foreach (string svar in besvarelser)
					sw.WriteLine(svar);
				
				sw.Close();
				sw.Dispose();
			}

        }
	}
}
