using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;

namespace Dzielnik.ModelWidoku.Komorki
{
    /// <summary>
    /// Adaptowalna zbiorcza komorka imienia oraz kwoty wejsciowej
    /// </summary>
    internal partial class KomorkaImieniaINaleznosciWejscowej : KomorkaZKolorowymTlemTekstuBaza, IKomorkaImieniaINaleznosciWejscowej
    {
        private readonly byte indeks;

        private readonly ICzyMoznaObliczacWkaznikUstal czyMoznaObliczacUstal;

        private readonly IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka konwerterTekstKwotyWejsciowej;

        /// <summary>
        /// Stworz komorke imienia i kwoty wejsciowej.
        /// </summary>
        public KomorkaImieniaINaleznosciWejscowej(byte indeks, IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka konwerterTekstKwotyWejsciowej,
            ICzyMoznaObliczacWkaznikUstal czyMoznaObliczacUstal)
        {
            this.indeks = indeks;

            imie = "Osoba " + (indeks +1).ToString();

            this.konwerterTekstKwotyWejsciowej = konwerterTekstKwotyWejsciowej;

            this.konwerterTekstKwotyWejsciowej.ZmianaTekstKwotyWejsciowejKonwerter_ObslugaZdarzenia +=
                KonwerterTekstKwotyWejsciowej_ZmianaTekstKwotyWejsciowejKonwerter_ArgumentyZdarzenia;
            
            this.czyMoznaObliczacUstal = czyMoznaObliczacUstal;

            //NaZmianeTekstKomorkiNaleznosci();
        }

        // wartosci zwracane w przypadku zlej implementacji interfejsu
        public new string Tekst
        {
            get => default(string);
            set {; }
        }
    }
}
