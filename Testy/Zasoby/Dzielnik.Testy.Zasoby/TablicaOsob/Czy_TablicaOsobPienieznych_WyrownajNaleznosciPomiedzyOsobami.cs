using System.Collections.Generic;

using Dzielnik.Testy.TablicaOsob;
using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Testy.Zasoby.Osoby;
using Dzielnik.Testy.Zasoby.TabliceOsob;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

using Xunit;

namespace Dzielnik.Testy.Zasoby.TablicaOsob
{
    public class Czy_TablicaOsobPienieznych_WyrownajNaleznosciPomiedzyOsobami
    {
        [Theory]
        [InlineData(new int[] { 1, 1 }, new int[] { 1, 1 }, (byte)0, (byte)1, 0)]
        [InlineData(new int[] { 2, 2 }, new int[] { 2, 2 }, (byte)0, (byte)1, 0)]
        [InlineData(new int[] { 2, 0 }, new int[] { 1, 1 }, (byte)0, (byte)1, 1)]
        [InlineData(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 }, (byte)0, (byte)0, 0)]
        [InlineData(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 }, (byte)0, (byte)1, 0)]
        [InlineData(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 }, (byte)0, (byte)3, 0)]
        [InlineData(new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, (byte)0, (byte)3, 0)]
        [InlineData(new int[] { 10, 1, 1, 0 }, new int[] { 5, 1, 1, 5 }, (byte)0, (byte)3, 5)]
        [InlineData(new int[] { 6, 2, 1, 0 }, new int[] { 3, 2, 1, 3 }, (byte)0, (byte)3, 3)]
        [InlineData(new int[] { 1, 10, 1, 2 }, new int[] { 1, 6, 1, 6 }, (byte)1, (byte)3, 4)]
        public void SpawdzCzy_TablicaOsob_WymienNaleznosciPomiedzyOsobami_WymieniaPrawidlowo
            (int[] naleznosciPoczatkowe, int[] naleznosciOczekiwane, byte iDKorzen, byte iDPotomek, int swiadczenieDoWymiany)
        {
            //Ustal
            ITablicaOsobPienieznychPrzekazywalna tablicaOsobPoczatkowe = Stworz_TablicaOsobPienieznych.Stworz(naleznosciPoczatkowe);
            
            IOsobaID osobaKorzen = Stworz_OsobaID_Moq.Stworz_ID_Moq(iDKorzen);

            IOsobaID osobaPotomek = Stworz_OsobaID_Moq.Stworz_ID_Moq(iDPotomek);

            INaleznoscPieniezna naleznoscDoWymiany = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Swiadczenie_Mock(swiadczenieDoWymiany);

            ITablicaOsobPienieznychIterowalna tablicaOsobOczekiwane =
                Stworz_TablicaOsobPienieznych_Mock.Stworz_GetEnumerator_Mock_Swiadczenie_Mock(naleznosciOczekiwane);

            //Dzialaj
            ITablicaOsobPienieznychIterowalna tablicaOsobObliczonych = tablicaOsobPoczatkowe.PrzekazNaleznosciPomiedzyOsobami(osobaKorzen, osobaPotomek, naleznoscDoWymiany);

            //Asercja
            IEnumerator<IOsobaSwiadczeniePieniezne> enumeratorObliczonychOsob = tablicaOsobObliczonych.GetEnumerator();

            IEnumerator<IOsobaSwiadczeniePieniezne> enumeratorOczekiwanychOsob = tablicaOsobOczekiwane.GetEnumerator();

            while (enumeratorObliczonychOsob.MoveNext() && enumeratorOczekiwanychOsob.MoveNext())
            {
                IOsobaSwiadczeniePieniezne osobaObliczona = enumeratorObliczonychOsob.Current;

                IOsobaSwiadczeniePieniezne osobaOczekiwana = enumeratorOczekiwanychOsob.Current;

                Assert.Equal(osobaObliczona.ID, osobaOczekiwana.ID);

                Assert.Equal(osobaObliczona.Wplata.Swiadczenie, osobaOczekiwana.Wplata.Swiadczenie);
            }
        }
    }
}