using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.ModelWidoku.Konwertery
{
    /// <summary>
    /// Konwerter tekstu z komorki kwoty wejsciowe na odpowiedni typ naleznosci pienieznej.
    /// </summary>
    internal partial class TekstKwotyWejsciowejNaleznosciPienieznejKonwerter : ITekstKwotyWejsciowejKonwerter
    {
        private IFabrykaNaleznoscPieniezna fabryka;

        private readonly INaleznoscPieniezna naleznoscZerowa;

        /// <summary>
        /// Stworz konwerter tekstu z komorki kwoty wejsciowe na odpowiedni typ nalznosci pienieznej.
        /// </summary>
        public TekstKwotyWejsciowejNaleznosciPienieznejKonwerter( IFabrykaNaleznoscPieniezna fabryka, INaleznoscPieniezna naleznoscZerowa)
        {
            this.fabryka = fabryka;

            this.naleznoscZerowa = naleznoscZerowa;
        }
    }
}