using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptowalne
{
    public class Czy_KomorkaDolnotrojkatnaKwotyNaleznej_Adaptowalna
    {
        [Fact]
        public void Czy_Tworzy_Prawidlowo()
        {
            //Ustal
            byte kolumna = default(byte);

            byte rzad = default(byte);

            string tekstZwrotny = "tEkSt ZwRoTnY";

            IKomorkaDolnotrojkatnaKwotyNaleznej komorka = Stworz_KomorkaKwotyNaleznej.Stworz(kolumna, rzad, tekstZwrotny) as IKomorkaDolnotrojkatnaKwotyNaleznej;

            //Dzialaj i Asercja
            AsertujKomorka.AsertujKolumne((byte)(rzad + 2), komorka.Kolumna);

            AsertujKomorka.AsertujRzad((byte) (kolumna + 1), komorka.Rzad);

            AsertujKomorka.AsertujTekst(tekstZwrotny.ToUpper(), komorka.Tekst);
        }
    }
}
