using System;

using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Zdarzenia;

namespace Dzielnik.ModelWidoku.Konwertery
{
    /// <summary>
    /// Prokurenta konwerterow tekstu z komorki kwoty wejsciowe na odpowiedni typ nalznosci.
    /// </summary>
    internal partial class KonwerterTekstKwotyWejsciowejProkurent : IKonwerterTekstKwotyWejsciowejProkurent
    {
        private ITekstKwotyWejsciowejKonwerter konwerter;

        public event EventHandler<ZmianaTekstKwotyWejsciowejKonwerter_ArgumentyZdarzenia> ZmianaTekstKwotyWejsciowejKonwerter_ObslugaZdarzenia;

        public KonwerterTekstKwotyWejsciowejProkurent(ITekstKwotyWejsciowejKonwerter konwerter)
        {
            this.konwerter = konwerter;
        }
    }
}