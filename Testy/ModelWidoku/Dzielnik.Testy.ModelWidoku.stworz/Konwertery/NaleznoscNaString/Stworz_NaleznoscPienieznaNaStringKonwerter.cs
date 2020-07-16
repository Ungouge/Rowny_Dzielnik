using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.NaleznoscNaString
{
    internal static class Stworz_NaleznoscPienieznaNaStringKonwerter
    {
        internal static INaleznoscNaStringKonwerter Stworz()
        {
            return new NaleznoscPienieznaNaStringKonwerter();
        }
    }
}
