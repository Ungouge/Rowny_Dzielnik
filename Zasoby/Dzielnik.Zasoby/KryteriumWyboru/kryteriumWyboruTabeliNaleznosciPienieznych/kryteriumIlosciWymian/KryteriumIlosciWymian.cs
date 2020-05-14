using System.Collections.Generic;
using System.Collections.ObjectModel;

using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Zasoby.KryteriumWyboru
{
    /// <summary>
    /// Kryterium wybory tabel naleznosci najmniejszej ilosci wymian potrzebnych do wyrownania naleznosci.
    /// </summary>
    internal partial class KryteriumIlosciWymian : KryteriumWezWymienionejNaleznosciPienieznejBaza, IKryteriumIlosciWymian
    {
        private readonly ICollection<IPolozenieGornotrojkatneWTabeliNaleznosci> zmienionePolozeniaKolekcja;
        
        public ushort WezIlosciWymian
        {
            get
            {
                return (ushort) zmienionePolozeniaKolekcja.Count;
            }
        }

        public KryteriumIlosciWymian(INaleznoscPieniezna wymienionaNaleznosc): base(wymienionaNaleznosc)
        {
            zmienionePolozeniaKolekcja = new Collection<IPolozenieGornotrojkatneWTabeliNaleznosci>();
        }

        private KryteriumIlosciWymian(ICollection<IPolozenieGornotrojkatneWTabeliNaleznosci> zmienionePolozeniaKolekcja,
            INaleznoscPieniezna wymienionaNaleznosc) : base(wymienionaNaleznosc)
        {
            this.zmienionePolozeniaKolekcja = zmienionePolozeniaKolekcja;
        }

        private KryteriumIlosciWymian(ICollection<IPolozenieGornotrojkatneWTabeliNaleznosci> zmienionePolozeniaKolekcja,
            IPolozenieGornotrojkatneWTabeliNaleznosci polozenieWTabeliNaleznosci, INaleznoscPieniezna wymienionaNaleznosc) : base(wymienionaNaleznosc)
        {
            zmienionePolozeniaKolekcja.Add(polozenieWTabeliNaleznosci);

            this.zmienionePolozeniaKolekcja = zmienionePolozeniaKolekcja;
        }
    }
}