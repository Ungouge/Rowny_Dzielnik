using System.Linq;

using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;
using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.ModelWidoku
{
    partial class ModelWidokuDzielnika
    {
        private ITablicaOsobBaza WezTablicaOsob()
        {
            switch (ustawienia.RodzajNaleznosciWylicznik)
            {
                case RodzajNaleznosciWylicznik.NaleznoscPieniezna:
                    goto default;
                default:
                    // W przypadku dodania ogolniejszej tablicy nalezy ja tu dodac, a to przeniesc do "case Zasoby.Wyliczniki.RodzajNaleznosciWylicznik.NaleznoscPieniezna:".
                    return StworzTablicaOsobPienieznych();
            }
        }

        private ITablicaOsobPienieznych StworzTablicaOsobPienieznych()
        {
            return fabrykaModelWidoku.StworzTablicaOsobPienieznych(PobierzSzeregOsob());
        } 

        private IOsobaTypSwiadczenia[] PobierzSzeregOsob()
        {
            return tabelaKomorek.
                IterujOsobyKomorekKwotyWejsciowej<IOsobaPieniezna>(fabrykaModelWidoku.WezKomorkaNaOsobaWizytor(ustawienia)).
                Reverse().
                ToArray();
        }
    }
}