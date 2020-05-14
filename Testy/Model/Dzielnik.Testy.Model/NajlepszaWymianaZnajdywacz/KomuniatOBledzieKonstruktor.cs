using System;
using System.Collections.Generic;

using Dzielnik.Testy.Zasoby.TabelaNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Testy.Model.NajlepszaWymianaZnajdywacz
{
    internal class KomuniatOBledzieKonstruktor
    {
        internal static string Sporzadz(int[][] y, ITabelaNaleznosciPienieznejZwrotna tabelaNaleznosciZnalezniona)
        {
            if (y.Length + 1 != tabelaNaleznosciZnalezniona.Rozmiar)
                return "Obliczona tabela jest niewlasciwego romiaru";

            string komunikatOBledzie = String.Empty;

            foreach (string komunikat in SporzadKomuniatOBledzieX(y, tabelaNaleznosciZnalezniona))
                komunikatOBledzie += komunikat;

            return komunikatOBledzie;
        }

        private static IEnumerable<string> SporzadKomuniatOBledzieX(int[][] y, ITabelaNaleznosciPienieznejZwrotna tabelaNaleznosciZnalezniona)
        {
            for (byte indeks_X = 1; indeks_X <= y.Length; indeks_X++)
                for (byte indeks_Y = 0; indeks_Y < indeks_X; indeks_Y++)
                {
                    int naleznoscOczekiwana = y[indeks_X - 1][indeks_Y];

                    int naleznoscZTeabeli = tabelaNaleznosciZnalezniona[Stworz_PolozenieWTabeliNaleznosci.Stworz(indeks_X, indeks_Y)].Swiadczenie;

                    if (naleznoscZTeabeli != naleznoscOczekiwana)
                        yield return String.Format("W polozeniu {0},{1} oczekiwana byla wartosc {2}, a aktualnie znajduje sie tam {3}.\n"
                            , indeks_X.ToString(), indeks_Y.ToString(), naleznoscOczekiwana, naleznoscZTeabeli);
                }
        }
    }
}
