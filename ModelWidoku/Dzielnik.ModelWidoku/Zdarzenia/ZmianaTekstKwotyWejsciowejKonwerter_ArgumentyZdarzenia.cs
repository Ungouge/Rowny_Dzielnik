using System;

namespace Dzielnik.ModelWidoku.Zdarzenia
{
    /// <summary>
    /// Argument zdarzenia zmiany konwertera tekstu kwoty wejsciowej.
    /// </summary>
    public class ZmianaTekstKwotyWejsciowejKonwerter_ArgumentyZdarzenia : EventArgs
    {
        private static ZmianaTekstKwotyWejsciowejKonwerter_ArgumentyZdarzenia WezPusty =>
            new ZmianaTekstKwotyWejsciowejKonwerter_ArgumentyZdarzenia();

        public static new readonly ZmianaTekstKwotyWejsciowejKonwerter_ArgumentyZdarzenia Empty = WezPusty;
    }
}