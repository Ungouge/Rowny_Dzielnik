using System;

using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Testy.Zasoby.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

using Moq;

namespace Dzielnik.Testy.Model.TabeleNaleznosci
{
    public static class Stworz_TabelaNaleznosciPienieznej_Mock
    {
        internal static ITabelaNaleznosciPienieznej Stworz_Mock()
        {
            return Stworz_MockWlasciwy().Object;
        }

        internal static ITabelaNaleznosciPienieznej 
            Stworz_TabelaNaleznosciPienieznej_KryteriumWyboruTabeliNaleznosci_WezWymienionaNaleznosc_Mock(int wymienionaNaleznosc)
        {
            Mock<ITabelaNaleznosciPienieznej> tabelaNaleznosciPienieznej_Mock = Stworz_MockWlasciwy();

            IKryteriumSumyWymienionejNaleznosciPienieznej kryteriuWyboru =
                Stworz_KryteriumSumyWymienionejNaleznosciPienieznej_Mock.Stworz_Kryterium_Naleznosc_Polgrsze_Mock(wymienionaNaleznosc);
            
            tabelaNaleznosciPienieznej_Mock.
                Setup(tabela => tabela.KryteriumWyboruTabeliNaleznosci).
                Returns(kryteriuWyboru);

            return tabelaNaleznosciPienieznej_Mock.Object;
        }

        internal static ITabelaNaleznosciPienieznej Stworz_TabelaNaleznosciPienieznej_ZwrocLepszeKryterium_ZwracajPodanyJezeliPrzeslanyPodany_Mock(
            ITabelaNaleznosciPienieznej tabelaNaleznosciDoZrocenia)
        {
            Mock<ITabelaNaleznosciPienieznej> tabelaNaleznosciPienieznej_Mock = Stworz_MockWlasciwy();

            tabelaNaleznosciPienieznej_Mock.Setup
            (
                tabela => tabela.ZwrocLepszeKryterium(It.IsAny<ITabelaNaleznosciPienieznej>())
            ).Returns
            (
                (ITabelaNaleznosciPienieznej tabelaNaleznosciPienieznej) => object.ReferenceEquals(tabelaNaleznosciPienieznej, tabelaNaleznosciDoZrocenia) ?
                tabelaNaleznosciDoZrocenia : tabelaNaleznosciPienieznej
            );

            tabelaNaleznosciPienieznej_Mock.Setup
            (
                tabela => tabela[It.IsAny<IPolozenieWTabeliNaleznosci>()]
            ).Throws
            (
                new Exception("Nie powinno zwrocic tej tabeli \"Dzielnik.Testy.Zasoby.TabeleNaleznosci.Stworz_TabelaNaleznosciPienieznej_Mock.Stworz_TabelaNaleznosciPienieznej_KryteriumWyboruTabeliNaleznosci_WezWymienionaNaleznosc_Mock(int wymienionaNaleznosc)\"")
            );

            return tabelaNaleznosciPienieznej_Mock.Object;
        }

        private static Mock<ITabelaNaleznosciPienieznej> Stworz_MockWlasciwy()
        {
            return new Mock<ITabelaNaleznosciPienieznej>();
        }
    }
}
