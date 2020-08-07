using System.Windows.Media;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Testy.ModelWidoku.Konwertery.TekstKwotyWejsciowej;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptowalne
{
    public partial class Czy_KomorkaWejsciowaKwoty_Adaptowalna
    {
        [Fact]
        public void Czy_KolorTla_PoKonwersjiNaPrawde()
        {
            //Ustal i dzialaj
            Brush kolorTla = KolorTlaPoKonwersji(true);

            //Asercja
            AsertujKomorka.AsertujKolorTla(Brushes.Transparent, kolorTla);
        }

        [Fact]
        public void Czy_KolorTla_PoKonwersjiNaFalsz()
        {
            //Ustal i dzialaj
            Brush kolorTla = KolorTlaPoKonwersji(false);

            // Asercja
            AsertujKomorka.AsertujKolorTla(Brushes.Red, kolorTla);
        }

        private static Brush KolorTlaPoKonwersji(bool czyKonwertuje)
        {
            //Ustal
            IKomorkaWejsciowaKwoty komorka = Stworz_KomorkaImieniaINaleznosciWejscowej.Stworz
            (
                czyKonwertuje,
                out IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka konwerterTekstKwotyWejsciowejProkurent
            ) as IKomorkaWejsciowaKwoty;

            //Dzialaj
            Stworz_KonwerterTekstKwotyWejsciowejProkurentDlaKomorka_Mock.Podnies_ZmianaTekstKwotyWejsciowejKonwerter(konwerterTekstKwotyWejsciowejProkurent);

            Brush kolorTla = komorka.KolorTla;

            return kolorTla;
        }
    }
}