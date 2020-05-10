using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Zasoby.TabeleNaleznosci
{
    /// <summary>
    /// Struktury zawierajaca koordynaty w tabeli naleznosci.
    /// </summary>
    public partial struct PolozenieWTabeliNaleznosci : IPolozenieWTabeliNaleznosci
    {
        private readonly byte indeks_X;

        private readonly byte indeks_Y;

        public PolozenieWTabeliNaleznosci(byte indeks_X, byte indeks_Y)
        {
            this.indeks_X = indeks_X;

            this.indeks_Y = indeks_Y;
        }

        public byte Indeks_X
        {
            get
            {
                return indeks_X;
            }
        }

        public byte Indeks_Y
        {
            get
            {
                return indeks_Y;
            }
        }
    }
}