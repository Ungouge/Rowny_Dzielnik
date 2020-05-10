using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Testy.Model.TabeleNaleznosci;
using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Testy.Zasoby.TabelaNaleznosci;

using Xunit;

namespace Dzielnik.Testy.Model.TabelaNaleznosci
{
    public class Czy_TabelaNaleznosciPienieznej_DodajNalzenoscKmorkiIUaktualnijKryterium
    {
        [Theory]
        [InlineData(0, 1, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(0, 1, -5)]
        [InlineData(0, 1, 357)]
        [InlineData(1, 0, 0)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 0, -5)]
        [InlineData(1, 0, 357)]
        [InlineData(3, 0, 0)]
        [InlineData(3, 0, 1)]
        [InlineData(3, 0, -5)]
        [InlineData(3, 0, 357)]
        [InlineData(1, 3, 0)]
        [InlineData(1, 3, 1)]
        [InlineData(1, 3, -5)]
        [InlineData(1, 3, 357)]
        public void Czy_UstawiaIZwraca_PrawidlowaWartosc(byte indeks_X, byte indeks_Y, int naleznoscWPolgroszach)
        {
            //Ustal
            ITabelaNaleznosciPienieznej tabelaNaleznosciPienieznej = Stworz_TabelaNaleznosciPienieznej.Stworz_Pusty();

            IPolozenieWTabeliNaleznosci polozenieWTabeli = Stworz_PolozenieWTabeliNaleznosci.Stworz(indeks_X, indeks_Y);

            INaleznoscPieniezna naleznoscOczekiwana = Stworz_NaleznoscPieniezna.Stworz(naleznoscWPolgroszach);

            //Dzialaj
            tabelaNaleznosciPienieznej.DodajWymianeNalzenosciUaktualniajacKryterium(naleznoscOczekiwana, polozenieWTabeli);

            INaleznoscPienieznaSwiadczenie naleznosc_Zwrocona = tabelaNaleznosciPienieznej[polozenieWTabeli];

            //Asercja
            Assert.Equal(naleznoscOczekiwana.Swiadczenie, naleznosc_Zwrocona.Swiadczenie);
        }

        [Theory]
        [InlineData(0, 1, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(0, 1, 5)]
        [InlineData(0, 1, 357)]
        [InlineData(1, 0, 0)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 0, -5)]
        [InlineData(1, 0, 357)]
        [InlineData(3, 0, 0)]
        [InlineData(3, 0, 1)]
        [InlineData(3, 0, -5)]
        [InlineData(3, 0, 357)]
        [InlineData(1, 3, 0)]
        [InlineData(1, 3, 1)]
        [InlineData(1, 3, -5)]
        [InlineData(1, 3, 357)]
        public void Czy_UstawiaIZwracaZPrzeciwnejStronyTabeli_PrawidlowaWartosc
            (byte indeks_X, byte indeks_Y, int naleznoscWPolgroszach)
        {
            //Ustal
            ITabelaNaleznosciPienieznej tabelaNaleznosciPienieznej = Stworz_TabelaNaleznosciPienieznej.Stworz_Pusty();

            IPolozenieWTabeliNaleznosci polozenieNaleznosciWTabeli = Stworz_PolozenieWTabeliNaleznosci.Stworz(indeks_X, indeks_Y);

            IPolozenieWTabeliNaleznosci polozeniePrzeciwlegleNaleznosciWTabeli = Stworz_PolozenieWTabeliNaleznosci.Stworz(indeks_Y, indeks_X);

            INaleznoscPieniezna naleznosc = Stworz_NaleznoscPieniezna.Stworz(naleznoscWPolgroszach);

            //Dzialaj
            tabelaNaleznosciPienieznej.DodajWymianeNalzenosciUaktualniajacKryterium(naleznosc, polozenieNaleznosciWTabeli);

            INaleznoscPienieznaSwiadczenie naleznosc_Zwrocona = tabelaNaleznosciPienieznej[polozeniePrzeciwlegleNaleznosciWTabeli];

            //Asercja
            Assert.Equal(naleznosc.Odwrotnosc().Swiadczenie, naleznosc_Zwrocona.Swiadczenie);
        }
    }
}