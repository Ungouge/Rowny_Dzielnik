using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptowalne
{
    public class Czy_KomorkaGornotrojkatnaKwotyNaleznej_Adaptowalna
    {
        [Fact]
        public void Czy_Tworzy_Prawidlowo()
        {
            //Ustal
            byte kolumna = default(byte);

            byte rzad = default(byte);

            string tekstZwrotny = "tEkSt ZwRoTnY";

            IKomorkaGornotrojkatnaKwotyNaleznej komorka = Stworz_KomorkaKwotyNaleznej.Stworz(kolumna, rzad, tekstZwrotny) as IKomorkaGornotrojkatnaKwotyNaleznej;

            //Dzialaj i Asercja
            AsertujKomorka.AsertujKolumne((byte)(kolumna + 2), komorka.Kolumna);

            AsertujKomorka.AsertujRzad((byte)(rzad + 1), komorka.Rzad);

            AsertujKomorka.AsertujTekst(tekstZwrotny.ToLower(), komorka.Tekst);
        }
    }
}
