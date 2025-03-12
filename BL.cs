using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

file abstract class Spørgsmål
{
    string beskrivelse = "";
    Image eksempelbillede;
    
    // Indlæs spørgsmål fra filstring
    Spørgsmål()
    {
        eksempelbillede = Image.FromFile();
    }

    // Tag input fra eleven
    void Svar()
    {

    }
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
    }
}
