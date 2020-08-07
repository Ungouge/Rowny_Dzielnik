using System.Collections.Generic;

using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

using Moq;

namespace Dzielnik.Testy.Model.TabeleNaleznosci
{
    public static class Stworz_TabelaNaleznosciZwrotna_Mock
    {
        public static ITabelaNaleznosciZwrotna Stworz_IndeksatorNaleznosci_Mock(out IDictionary<IPolozenieWTabeliNaleznosci, INaleznoscSwiadczenieBaza> naleznosciSlownik)
        {
            Mock<ITabelaNaleznosciZwrotna> tabelaNaleznosciPienieznej_Mock = new Mock<ITabelaNaleznosciZwrotna>();

            naleznosciSlownik = new Dictionary<IPolozenieWTabeliNaleznosci, INaleznoscSwiadczenieBaza>();

            TabelaZNaleznoscia_ObslugaSlownika obslugaSlownikaNaleznosci = new TabelaZNaleznoscia_ObslugaSlownika(naleznosciSlownik);

            tabelaNaleznosciPienieznej_Mock.
                Setup(tabela => tabela[It.IsAny<IPolozenieWTabeliNaleznosci>()]).
                Returns((IPolozenieWTabeliNaleznosci polozenieKlucz) => obslugaSlownikaNaleznosci.NaleznoscZeSlwonika(polozenieKlucz));

            return tabelaNaleznosciPienieznej_Mock.Object;
        }
    }

    public class TabelaZNaleznoscia_ObslugaSlownika
    {
        readonly IDictionary<IPolozenieWTabeliNaleznosci, INaleznoscSwiadczenieBaza> naleznosciSlownik;

        public TabelaZNaleznoscia_ObslugaSlownika(IDictionary<IPolozenieWTabeliNaleznosci, INaleznoscSwiadczenieBaza> naleznosciSlownik)
        {
            this.naleznosciSlownik = naleznosciSlownik;
        }

        public INaleznoscSwiadczenieBaza NaleznoscZeSlwonika(IPolozenieWTabeliNaleznosci polozenieKlucz)
        {
            INaleznoscSwiadczenieBaza naleznosc = Stworz_NaleznoscSwiadczenieBaza_Mock.Stworz_Mock();

            if (naleznosciSlownik.ContainsKey(polozenieKlucz) == true)
                return naleznosciSlownik[polozenieKlucz];

            naleznosciSlownik.Add(polozenieKlucz, naleznosc);

            return naleznosc;
        }
    }
}