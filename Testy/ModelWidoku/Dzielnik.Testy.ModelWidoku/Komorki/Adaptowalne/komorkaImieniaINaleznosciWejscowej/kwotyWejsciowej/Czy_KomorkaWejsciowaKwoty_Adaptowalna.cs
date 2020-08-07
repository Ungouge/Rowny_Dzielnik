using System;
using System.Windows.Media;  

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptowalne
{
    public partial class Czy_KomorkaWejsciowaKwoty_Adaptowalna
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(179)]
        public void Czy_Tworzy_Prawidlowo(byte indeks)
        {
            //Ustal
            IKomorkaWejsciowaKwoty komorka = Stworz_KomorkaImieniaINaleznosciWejscowej.Stworz(indeks) as IKomorkaWejsciowaKwoty;

            //Dzialaj i Asercja
            AsertujKomorka.AsertujKolumne(1, komorka.Kolumna);

            AsertujKomorka.AsertujRzad((byte)(indeks + 1), komorka.Rzad);

            AsertujKomorka.AsertujTekst(String.Empty, komorka.Tekst);

            AsertujKomorka.AsertujKolorTla(Brushes.Transparent, komorka.KolorTla);
        }
    }
}
