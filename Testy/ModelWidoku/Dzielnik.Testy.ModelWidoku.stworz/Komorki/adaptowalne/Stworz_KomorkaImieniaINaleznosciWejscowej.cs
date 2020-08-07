using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Komorki;
using Dzielnik.Testy.ModelWidoku.CzyMoznaObliczac;
using Dzielnik.Testy.ModelWidoku.Konwertery.TekstKwotyWejsciowej;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static class Stworz_KomorkaImieniaINaleznosciWejscowej
    {
        internal static IKomorkaImieniaINaleznosciWejscowej Stworz(bool czyKonwertuje, out IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka konwerter)
        {
            konwerter = Stworz_KonwerterTekstKwotyWejsciowejProkurentDlaKomorka_Mock.Stworz_Konwertuj_Mock(czyKonwertuje);

            return Stworz(konwerter);
        }

        internal static IKomorkaImieniaINaleznosciWejscowej Stworz(IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka konwerter)
        {
            ICzyMoznaObliczacWkaznikUstal czyMoznaObliczac = Stworz_CzyMoznaObliczacWkaznik_Mock.Stworz_Mock();
           
            return Stworz(default(byte), konwerter);
        }

        internal static IKomorkaImieniaINaleznosciWejscowej Stworz(byte indeks)
        {
            IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka konwerter = Stworz_KonwerterTekstKwotyWejsciowejProkurentDlaKomorka_Mock.Stworz_Mock();

            return Stworz(indeks, konwerter);
        }

        internal static IKomorkaImieniaINaleznosciWejscowej Stworz(byte indeks, IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka konwerter)
        {
            ICzyMoznaObliczacWkaznikUstal czyMoznaObliczac = Stworz_CzyMoznaObliczacWkaznik_Mock.Stworz_Mock();

            return new KomorkaImieniaINaleznosciWejscowej(indeks, konwerter, czyMoznaObliczac);
        }
    }
}
