using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

using Moq;

namespace Dzielnik.Testy.Zasoby.TabelaNaleznosci
{
    public static class Stworz_PolozenieWTabeliNaleznosci_Mock
    {
        public static IPolozenieWTabeliNaleznosci Stworz_IndeksyPolozenia_Mock (byte indeks_X, byte indeks_Y)
        {
            Mock<IPolozenieWTabeliNaleznosci> polozenieWTabeliNaleznosci = new Mock<IPolozenieWTabeliNaleznosci>();

            polozenieWTabeliNaleznosci.
                Setup(polozenie => polozenie.Indeks_X).
                Returns(indeks_X);

            polozenieWTabeliNaleznosci.
                Setup(polozenie => polozenie.Indeks_Y).
                Returns(indeks_Y);

            return polozenieWTabeliNaleznosci.Object;    
        }
    }
}