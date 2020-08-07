using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptowalne
{
    public class Czy_KomorkaZWejsciemTekstu_Adaptowalna
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(179)]
        public void Czy_Tworzy_Prawidlowo(byte indeks)
        {
            //Ustal
            IKomorkaZWejsciemTekstu komorka = Stworz_KomorkaImieniaINaleznosciWejscowej.Stworz(indeks) as IKomorkaZWejsciemTekstu;

            //Dzialaj i Asercja
            AsertujKomorka.AsertujKolumne(0, komorka.Kolumna);

            AsertujKomorka.AsertujRzad((byte)(indeks + 1), komorka.Rzad);

            AsertujKomorka.AsertujTekst(default(string), komorka.Tekst);
        }
    }
}
