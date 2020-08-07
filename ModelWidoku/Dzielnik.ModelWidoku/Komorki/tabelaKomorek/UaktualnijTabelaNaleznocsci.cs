using System.Collections.Generic;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class TabelaKomorek
    {
        public void UaktualnijTabelaNaleznocsci(ITabelaNaleznosciZwrotna tabelaNaleznosci)
        {
            Stack<IKomorkaKwotyNaleznej[]> wylicznikKomorekKwotyNaleznej = OdwocStosKomorekKwotyNaleznej();

            for (byte indeks_X = 0; indeks_X < tabelaNaleznosci.Rozmiar; indeks_X++)
            {
                IKomorkaKwotyNaleznej[] tabelaKomorek = wylicznikKomorekKwotyNaleznej.Pop();

                for (byte indeks_Y = 0; indeks_Y < indeks_X; indeks_Y++)
                {
                    IPolozenieWTabeliNaleznosci polozeniaWTabeli = fabrykaDlaTabelaKomorek.StworzPolozenieWTabeliNaleznosci(indeks_X, indeks_Y);

                    tabelaKomorek[indeks_Y].UstalNaleznosc(tabelaNaleznosci[polozeniaWTabeli]);
                }
            }
        }

        private Stack<IKomorkaKwotyNaleznej[]> OdwocStosKomorekKwotyNaleznej()
        {
            Stack<IKomorkaKwotyNaleznej[]> odwroconyStos = new Stack<IKomorkaKwotyNaleznej[]>();

            foreach (IKomorkaKwotyNaleznej[] tableaKomorek in komorkiKwotyNaleznej)
                odwroconyStos.Push(tableaKomorek);

            return odwroconyStos;
        }
    }
}
