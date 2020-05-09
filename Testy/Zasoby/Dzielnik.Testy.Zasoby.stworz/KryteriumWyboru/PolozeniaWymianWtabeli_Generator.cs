using System.Collections.Generic;

using Dzielnik.Testy.Zasoby.TabelaNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru
{
    public static class PolozeniaWymianWTabeli_Generator
    {
        public static IEnumerable<IPolozenieWTabeliNaleznosci> GenerujKolejnePolozeniaWymianWtabeli(ushort iloscWymian)
        {
            foreach (IPolozenieWTabeliNaleznosci polozenie in GenerujKolejnePolozeniaWymianWtabeliOd(iloscWymian))
                yield return polozenie;
        }

        public static IEnumerable<IPolozenieWTabeliNaleznosci> GenerujKolejnePolozeniaWymianWtabeli(ushort iloscWymian, ushort iloscWymainPominietych)
        {
            byte indeks_X = 1;

            byte indeks_Y = PominWymiany(iloscWymainPominietych, ref indeks_X);

            if (indeks_Y > 0)
            {
                foreach (IPolozenieWTabeliNaleznosci polozenie in GenerujKolejnePolozeniaWymianWRzedzie(iloscWymian, indeks_X, indeks_Y))
                    yield return polozenie;
                
                iloscWymian = OdejmijBezznakowy(iloscWymian, (byte)(indeks_X - indeks_Y));

                indeks_X++;
            }

            foreach (IPolozenieWTabeliNaleznosci polozenie in GenerujKolejnePolozeniaWymianWtabeliOd(iloscWymian, indeks_X))
                yield return polozenie;
        }

        private static byte PominWymiany( ushort iloscWymainPominietych, ref byte indeks_X)
        {
            for (; iloscWymainPominietych >= indeks_X; indeks_X++)
                iloscWymainPominietych = OdejmijBezznakowy(iloscWymainPominietych, indeks_X);

            return (byte) iloscWymainPominietych;
        }

        private static IEnumerable<IPolozenieGornotrojkatneWTabeliNaleznosci> GenerujKolejnePolozeniaWymianWtabeliOd(ushort iloscWymian, byte indeks_X = 1)
        {
            for (; iloscWymian > 0; iloscWymian = OdejmijBezznakowy(iloscWymian, indeks_X++))
                foreach (IPolozenieWTabeliNaleznosci polozenie in GenerujKolejnePolozeniaWymianWRzedzie(iloscWymian, indeks_X))
                    yield return polozenie;
        }

        private static IEnumerable<IPolozenieGornotrojkatneWTabeliNaleznosci> GenerujKolejnePolozeniaWymianWRzedzie(ushort iloscWymian, byte indeks_X, byte indeks_Y = 0)
        {
            for (; indeks_Y < indeks_X && iloscWymian-- > 0; indeks_Y++)
                yield return Stworz_PolozenieWTabeliNaleznosci.Stworz(indeks_X, indeks_Y);
        }

        private static ushort OdejmijBezznakowy(ushort odjemna, byte odjemnik)
        {
            return (ushort)(odjemna > odjemnik ? odjemna - odjemnik : 0);
        }
    }
}