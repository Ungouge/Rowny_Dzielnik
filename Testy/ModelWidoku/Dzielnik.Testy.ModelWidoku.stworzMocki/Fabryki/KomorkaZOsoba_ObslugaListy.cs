using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.Testy.ModelWidoku.Komorki;
using Dzielnik.Testy.Zasoby.Osoby.OsobaTypSwiadczenia;
using Dzielnik.Zasoby.Interfejsy.Osoby;

using System.Collections.Generic;

namespace Dzielnik.Testy.ModelWidoku.Fabryki
{
    public static partial class Stworz_FabrykaModeluWidokuDlaTabelaKomorek_Mock
    {
        private class KomorkaZOsoba_ObslugaListy
        {
            IList<IOsobaTypSwiadczenia> osobyLista;

            public KomorkaZOsoba_ObslugaListy(IList<IOsobaTypSwiadczenia> osobyLista)
            {
                this.osobyLista = osobyLista;
            }

            public IKomorkaImieniaINaleznosciWejscowej StworzKomorkaZOsoba()
            {
                IOsobaTypSwiadczenia osoba = Stworz_OsobaTypSwiadczenia_Mock.Stworz_Mock();

                osobyLista.Add(osoba);

                return Stworz_KomorkaImieniaINaleznosciWejscowej_Mock.Stworz_WezOsoba_Mock(osoba);
            }
        }
    }
}