using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    internal class AsertujKomorka
    {
        public static void Asertuj<TKomorkaZKolorowymTlemTekstu>(byte kolumnaZadana, byte rzadZadany, string tekstZadany, Brush kolorTlaZadany, TKomorkaZKolorowymTlemTekstu komorka)
            where TKomorkaZKolorowymTlemTekstu : IKomorkaZKolorowymTlemTekstu
        {
            AsertujKomorka.Asertuj(kolumnaZadana, rzadZadany, tekstZadany, komorka);

            AsertujKolorTla(kolorTlaZadany, komorka.KolorTla);
        }

        internal static void Asertuj<TKomorkaZTekstem>(byte kolumnaZadana, byte rzadZadana, string tekstZadana, TKomorkaZTekstem komorka) where TKomorkaZTekstem : IKomorkaZTekstem
        {
            AsertujKolumne(kolumnaZadana, komorka.Kolumna);

            AsertujRzad(rzadZadana, komorka.Rzad);

            AsertujTekst(tekstZadana, komorka.Tekst);
        }

        internal static void AsertujKolumne(byte kolumnaZadana, byte kolumnaZwrocona)
        {
            //Asercja
            Assert.Equal(kolumnaZadana, kolumnaZwrocona);
        }

        internal static void AsertujRzad(byte rzadZadany, byte rzadZwrocony)
        {
            //Asercja
            Assert.Equal(rzadZadany, rzadZwrocony);
        }

        internal static void AsertujTekst(string tekstZadany, string testZwrocony)
        {
            //Asercja
            Assert.Equal(tekstZadany, testZwrocony);
        }
    }
}