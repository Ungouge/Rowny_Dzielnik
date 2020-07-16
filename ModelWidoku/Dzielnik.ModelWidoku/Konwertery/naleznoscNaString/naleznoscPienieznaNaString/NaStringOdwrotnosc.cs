using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.ModelWidoku.Interfejsy.Konwertery
{
    partial class NaleznoscPienieznaNaStringKonwerter
    {
        public string NaStringOdwrotnosc(INaleznoscSwiadczenieBaza naleznosc)
        {
            if (naleznosc is INaleznoscPienieznaSwiadczenie naleznoscPieniezna)
                return NaString(naleznoscPieniezna, true);

            return zlyTyp;
        }
    }
}