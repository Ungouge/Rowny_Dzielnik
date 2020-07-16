using System;

using Dzielnik.ModelWidoku.Zdarzenia;

namespace Dzielnik.ModelWidoku.Interfejsy.Konwertery
{
    /// <summary>
    /// Interfejs dla prokurenta konwerterow tekstu z komorki kwoty wejsciowe na odpowiedni typ naleznosci przeznaczony dla komorek tabeli.
    /// </summary>
    internal interface IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka : ITekstKwotyWejsciowejKonwerter
    {
        /// <summary>
        /// Obsluguje zdarzenia wykonywane na zmiane konwertera.
        /// </summary>
        event EventHandler<ZmianaTekstKwotyWejsciowejKonwerter_ArgumentyZdarzenia> ZmianaTekstKwotyWejsciowejKonwerter_ObslugaZdarzenia;
    }
}