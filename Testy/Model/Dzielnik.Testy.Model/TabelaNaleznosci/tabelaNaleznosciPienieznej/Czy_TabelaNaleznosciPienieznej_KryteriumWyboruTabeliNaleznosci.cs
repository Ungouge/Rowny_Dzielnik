using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Testy.Model.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.KryteriumWyboru;

using Xunit;

namespace Dzielnik.Testy.Model.TabelaNaleznosci
{
    public class Czy_TabelaNaleznosciPienieznej_KryteriumWyboruTabeliNaleznosci
    {
        [Fact]
        public void Czy_Zwraca_PrawidlowegoTypu_KryteriumIlosciWymian()
        {
            //Ustal i Dzialaj
            ITabelaNaleznosciPienieznej tabelaNaleznosci = 
                Stworz_TabelaNaleznosciPienieznej.Stworz_Pusty(4, KryteriumWyboruTabeliNaleznosciWylicznik.IlosciWymian);

            //Asercja
            Assert.IsType<KryteriumIlosciWymian>(tabelaNaleznosci.KryteriumWyboruTabeliNaleznosci);
        }

        [Fact]
        public void Czy_Zwraca_PrawidlowegoTypu_KryteriumSumyWymienionejNaleznosciPienieznej()
        {
            //Ustal i Dzialaj
            ITabelaNaleznosciPienieznej tabelaNaleznosci = Stworz_TabelaNaleznosciPienieznej.Stworz_Pusty(4, KryteriumWyboruTabeliNaleznosciWylicznik.KryteriumSumyWymienionejNaleznosci);

            //Asercja
            Assert.IsType<KryteriumSumyWymienionejNaleznosciPienieznej>(tabelaNaleznosci.KryteriumWyboruTabeliNaleznosci);
        }
    }
}
