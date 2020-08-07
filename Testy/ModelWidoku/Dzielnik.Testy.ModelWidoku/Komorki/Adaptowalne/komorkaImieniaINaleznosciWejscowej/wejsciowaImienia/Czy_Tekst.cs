using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptowalne
{
    public partial class Czy_KomorkaWejsciowaImienia_Adaptowalna
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(179)]
        public void Czy_Tekst(byte indeks)
        {
            //Ustal
            IKomorkaImieniaINaleznosciWejscowej komorka = Stworz_KomorkaImieniaINaleznosciWejscowej.Stworz(indeks);

            //Dzialaj
            string nowyTekst = default(string);

            (komorka as IKomorkaWejsciowaImienia).Tekst = nowyTekst;

            //Asercja
            AsertujKomorka.AsertujTekst(nowyTekst, (komorka as IKomorkaWejsciowaImienia).Tekst);

            AsertujKomorka.AsertujTekst(nowyTekst, (komorka as IKomorkaWyjsciowaImienia).Tekst);
        }
    }
}