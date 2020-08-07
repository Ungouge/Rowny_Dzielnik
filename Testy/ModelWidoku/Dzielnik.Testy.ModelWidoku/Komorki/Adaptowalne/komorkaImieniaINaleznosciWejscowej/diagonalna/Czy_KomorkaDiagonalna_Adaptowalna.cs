using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptowalne
{
    public class Czy_KomorkaDiagonalna_Adaptowalna
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(179)]
        public void Czy_Tworzy_Prawidlowo(byte indeks)
        {
            //Ustal
            IKomorkaDiagonalna komorka = Stworz_KomorkaImieniaINaleznosciWejscowej.Stworz(indeks) as IKomorkaDiagonalna;

            //Dzialaj i Asercja
            AsertujKomorka.AsertujKolumne((byte)(indeks + 2),komorka.Kolumna);
            
            AsertujKomorka.AsertujRzad((byte)(indeks + 1), komorka.Rzad);

            AsertujKomorka.AsertujTekst("—", komorka.Tekst);
        }
    }
}
