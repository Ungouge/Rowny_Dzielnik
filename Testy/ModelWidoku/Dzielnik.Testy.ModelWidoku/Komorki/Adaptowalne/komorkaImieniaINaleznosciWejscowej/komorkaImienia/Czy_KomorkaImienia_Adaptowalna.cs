using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptowalne
{
    public class Czy_KomorkaImienia_Adaptowalna
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(179)]
        public void Czy_Tworzy_Prawidlowo(byte indeks)
        {
            //Ustal
            IKomorkaImienia komorka = Stworz_KomorkaImieniaINaleznosciWejscowej.Stworz(indeks) as IKomorkaImienia;

            //Dzialaj i Asercja
            AsertujKomorka.AsertujKolumne(0, komorka.Kolumna);

            AsertujKomorka.AsertujRzad(0, komorka.Rzad);

            AsertujKomorka.AsertujTekst("Osoba " + (indeks + 1).ToString(), komorka.Tekst);
        }
    }
}
