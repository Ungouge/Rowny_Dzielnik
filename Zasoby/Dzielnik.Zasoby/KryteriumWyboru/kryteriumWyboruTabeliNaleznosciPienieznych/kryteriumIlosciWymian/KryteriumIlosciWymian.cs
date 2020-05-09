using System.Collections.Generic;
using System.Collections.ObjectModel;

using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Zasoby.KryteriumWyboru
{
    /// <summary>
    /// Kryterium wybory tabel naleznosci najmniejszej ilosci wymian potrzebnych do wyrownania naleznosci.
    /// </summary>
    internal partial class KryteriumIlosciWymian : KryteriumWyboruTabeliNaleznosciPienieznychBaza, IKryteriumIlosciWymian
    {
        private readonly ICollection<IPolozenieGornotrojkatneWTabeliNaleznosci> zmienionePolozeniaKolekcja;
        
        public ushort WezIlosciWymian
        {
            get
            {
                return (ushort) zmienionePolozeniaKolekcja.Count;
            }
        }

        public KryteriumIlosciWymian()
        {
            zmienionePolozeniaKolekcja = new Collection<IPolozenieGornotrojkatneWTabeliNaleznosci>();
        }

        private KryteriumIlosciWymian(ICollection<IPolozenieGornotrojkatneWTabeliNaleznosci> zmienionePolozeniaKolekcja,
            IPolozenieGornotrojkatneWTabeliNaleznosci polozenieWTabeliNaleznosci)
        {
            zmienionePolozeniaKolekcja.Add(polozenieWTabeliNaleznosci);

            this.zmienionePolozeniaKolekcja = zmienionePolozeniaKolekcja;
        }
    }
}