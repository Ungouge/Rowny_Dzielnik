using System;
using System.Runtime.Serialization;

using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.Zasoby.Wyjatki
{
    /// <summary>
    /// Wyjatek ten jest wyrzucany w przypadku, gdy zostanie przeslany lub zazadany typ naleznosci zawierajacy niewlasciwy typ swiadczenia. 
    /// </summary>
    public class ZlyTypNaleznosciWyjatek : Exception
    {
        public ZlyTypNaleznosciWyjatek()
        {
        }

        public ZlyTypNaleznosciWyjatek(string message) :
            base
            (
                message
                )
        {
        }

        public ZlyTypNaleznosciWyjatek(object klasaWKtorejNieZamplementowanoWyjatku, Type NieZamplementowanyInterfejs):
            base
            (
                "Blednie przeslano " + NieZamplementowanyInterfejs.GetType().ToString() + " do " + klasaWKtorejNieZamplementowanoWyjatku.GetType().ToString() + "."
            ) { }

        public ZlyTypNaleznosciWyjatek(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ZlyTypNaleznosciWyjatek(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}