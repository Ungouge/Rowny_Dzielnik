using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptowalne
{
    public class Czy_KomorkaWyjsciowaImienia_Adaptowalna
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(179)]
        public void Czy_Tworzy_Prawidlowo(byte indeks)
        {
            //Ustal
            IKomorkaWyjsciowaImienia komorka = Stworz_KomorkaImieniaINaleznosciWejscowej.Stworz(indeks) as IKomorkaWyjsciowaImienia;

            //Dzialaj i Asercja
            AsertujKomorka.AsertujKolumne((byte)(indeks + 2), komorka.Kolumna);

            AsertujKomorka.AsertujRzad(0, komorka.Rzad);

            AsertujKomorka.AsertujTekst("Osoba " + (indeks + 1).ToString(), komorka.Tekst);
        }
    }
}
