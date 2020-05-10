using System;

using Dzielnik.Model.Fabryki;
using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Testy.Zasoby.TabelaNaleznosci;
using Dzielnik.Zasoby.Fabryki;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Testy.Model.TabeleNaleznosci
{
    public static class Stworz_TabelaNaleznosciPienieznej
    {
        private static readonly IFabrykaTabelaNalezosciPienieznej fabrykaTabelaNaleznosci = new FabrykaTabelaNalezosciPienieznej
        (
            new AbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych (new FabrykaNaleznoscPienieznaZerowa()),
            new AbstrakcyjnaFabrykaNaleznosciPienieznejDlaTabeliNaleznosci(new FabrykaNaleznoscPienieznaDiagonalna(), new FabrykaNaleznoscPienieznaZerowa())
        );

        internal static ITabelaNaleznosciPienieznej Stworz(int sumaNaleznosciDoTabeli, byte iloscOsob = 4,
            KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci = default(KryteriumWyboruTabeliNaleznosciWylicznik))
        {
            ITabelaNaleznosciPienieznej tabelaNaleznosci = Stworz_Pusty(iloscOsob, kryteriumWyboruTabeliNaleznosci);

            Random GeneratorLiczbPseudolosowych = new Random();

            for (byte indeks_X = 2; indeks_X < iloscOsob; indeks_X++)
                for (byte indeks_Y = 0; indeks_Y < indeks_X; indeks_Y++)
                {
                    int komorka = GeneratorLiczbPseudolosowych.Next(sumaNaleznosciDoTabeli);

                    if (komorka > 0)
                    {
                        sumaNaleznosciDoTabeli -= komorka;

                        IPolozenieWTabeliNaleznosci polozenieWTabeli =
                            Stworz_PolozenieWTabeliNaleznosci.Stworz(indeks_X, indeks_Y);

                        tabelaNaleznosci.
                            DodajWymianeNalzenosciUaktualniajacKryterium(Stworz_NaleznoscPieniezna.Stworz(komorka), polozenieWTabeli);
                    }
                }

            if (sumaNaleznosciDoTabeli > 0)
            {
                IPolozenieWTabeliNaleznosci polozenieWTabeli =
                    Stworz_PolozenieWTabeliNaleznosci.Stworz(1, 0);

                tabelaNaleznosci.
                    DodajWymianeNalzenosciUaktualniajacKryterium(Stworz_NaleznoscPieniezna.Stworz(sumaNaleznosciDoTabeli), polozenieWTabeli);
            }

            return tabelaNaleznosci;
        }

        internal static ITabelaNaleznosciPienieznej Stworz(int[][] naleznosciDoTabeliNalznosci,
            KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci = default(KryteriumWyboruTabeliNaleznosciWylicznik))
        {
            byte iloscOsob = (byte) naleznosciDoTabeliNalznosci.GetLength(0);

            ITabelaNaleznosciPienieznej tabelaNaleznosci = Stworz_Pusty((byte) (iloscOsob + 1), kryteriumWyboruTabeliNaleznosci);
            
            for (byte indeks_X = 0; indeks_X < iloscOsob; indeks_X++)
                for (byte indeks_Y = 0; indeks_Y <= indeks_X; indeks_Y++)
                {
                    int komorka = naleznosciDoTabeliNalznosci[indeks_X][indeks_Y];

                    if (komorka != 0)
                        tabelaNaleznosci.
                            DodajWymianeNalzenosciUaktualniajacKryterium(Stworz_NaleznoscPieniezna.Stworz(komorka),
                            Stworz_PolozenieWTabeliNaleznosci.Stworz((byte) (indeks_X +1), indeks_Y));
                }

            return tabelaNaleznosci;
        }

        internal static ITabelaNaleznosciPienieznej Stworz_Pusty ( byte iloscOsob = 4, KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci =
            default(KryteriumWyboruTabeliNaleznosciWylicznik))
        {
            return fabrykaTabelaNaleznosci.StworzTabelaNaleznosci(iloscOsob, kryteriumWyboruTabeliNaleznosci);
        }
    }
}