using System;

using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model.TabelaNaleznosci
{
    partial class TabelaNaleznosciPienieznej : TabelaNaleznosciPienieznejBaza, ITabelaNaleznosciPienieznej
    {
        public override INaleznoscPienieznaSwiadczenie this[IPolozenieWTabeliNaleznosci polozenieWTabeli]
        {
            get
            {
                SprawdzCzyJestWZasiegu(polozenieWTabeli);

                return polozenieWTabeli.CzyKoordynatyDiagonalne ?
                    base[polozenieWTabeli] :
                    this[polozenieWTabeli as IPolozenieGornotrojkatneWTabeliNaleznosci];
            }
        }

        private INaleznoscPieniezna this[IPolozenieGornotrojkatneWTabeliNaleznosci polozenieWTabeli]
        {
            get
            {
                INaleznoscPieniezna nowaNaleznoscPieniezna = tabelaKomorekNaleznosci[polozenieWTabeli.Indeks_X][polozenieWTabeli.Indeks_Y];

                return nowaNaleznoscPieniezna == null ?
                    abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci.StworzNaleznoscPienieznaZerowa() :
                    polozenieWTabeli.CzyKoordynatyGorntrojkatne ? nowaNaleznoscPieniezna : nowaNaleznoscPieniezna.Odwrotnosc();
            }
            set
            {
                //!Uwaga nie wprowadza zmian w kryterium naleznosci - uzywac jedynie do samej zmiany wartosci!! 

                tabelaKomorekNaleznosci[polozenieWTabeli.Indeks_X][polozenieWTabeli.Indeks_Y] = value;
            }
        }

        private void SprawdzCzyJestWZasiegu(IPolozenieWTabeliNaleznosci polozenieWTabeli)
        {
            if (polozenieWTabeli.Indeks_X > Rozmiar || polozenieWTabeli.Indeks_Y > Rozmiar)
                throw new ArgumentOutOfRangeException();
        }
    }
}