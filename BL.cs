using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Spørgsmål
{
    string beskrivelse = "";
    Image eksempelbillede = null;
    
    // Fra fil
    void IndlæsSpørgsmål(string fil)
    {
        using (StreamReader sr = new StreamReader(fil))
        {
            
        };
    }

    // Til fil
    void GemSpørgsmål(string fil, string billede_fil)
    {
        using (StreamWriter sw = new StreamWriter(fil))
        {
            sw.WriteLine(beskrivelse);
            sw.WriteLine(billede_fil);
            sw.Close();
        };
    }

    // Tag input fra eleven
    public abstract void Svar();
}

file class MultipleChoice : Spørgsmål
{
    
}

file class ÅbentSvar : Spørgsmål
{

}

public class Opgave
{
    // Hvor mange Spørgsmål har eleven svaret rigtigt på?
    int AntalRigtige()
    {

    }

    // Returnerer som decimaltal mellem 0 og 1
    float AndelRigtige()
    {

    }
}

namespace Eksamensprojekt
{
    internal class BL
    {
        // -1: Ikke bruger, 0: Elev, 1: Lærer
        int ErBruger(string brugernavn, string adgangskode)
        {

        }
    }
}
