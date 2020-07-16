using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Konwertery;
using System;
using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Fabryki;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.TekstKwotyWejsciowej
{
    internal static class Stworz_TekstKwotyWejsciowejNaleznosciPienieznejKonwerter
    {
        static readonly INaleznoscPieniezna naleznoscPienieznaZerowa = Stworz_NaleznoscPienieznaZerowa.Stworz();

        static readonly IFabrykaNaleznoscPieniezna fabrykaNaleznoscPieniezna = new FabrykaNaleznoscPieniezna();

        internal static  ITekstKwotyWejsciowejKonwerter Stworz()
        {
            return new TekstKwotyWejsciowejNaleznosciPienieznejKonwerter(fabrykaNaleznoscPieniezna, naleznoscPienieznaZerowa);
        }
    }
}
