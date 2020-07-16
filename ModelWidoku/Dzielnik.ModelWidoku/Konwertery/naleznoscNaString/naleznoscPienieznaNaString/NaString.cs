using System;

using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.ModelWidoku.Interfejsy.Konwertery
{
    partial class NaleznoscPienieznaNaStringKonwerter
    {
        private readonly string pusty = String.Empty;

        public string NaString(INaleznoscSwiadczenieBaza naleznosc)
        {
            if (naleznosc is INaleznoscPienieznaSwiadczenie naleznoscPieniezna)
                return NaString(naleznoscPieniezna, false);

            return zlyTyp;
        }
        
        private string NaString(INaleznoscPienieznaSwiadczenie naleznosc, bool odwrotnosc)
        {
            int grosze = naleznosc.Swiadczenie;

            if (grosze == 0)
                return pusty;

            if (grosze < 0 ^ odwrotnosc)
                return NaStringOdwrotnoscBezwglednej(grosze);

            return NaStringBezwgledna(grosze);
        }

        private string NaStringOdwrotnoscBezwglednej(int grosze)
        {
            return NaStringBezwgledna(grosze).Insert(0, "-");
        }

        private string NaStringBezwgledna(int grosze)
        {
            if (grosze < 0)
                grosze = -grosze;

            string groszeText = grosze.ToString();

            while (groszeText.Length < 3)
                groszeText = groszeText.Insert(0, "0");

            if (groszeText.Substring(groszeText.Length - 2, 2) == "00")
                return groszeText.Substring(0, groszeText.Length - 2);

            return groszeText.Insert(groszeText.Length - 2, ",");
        }
    }
}