using System;
using System.Linq.Expressions;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    internal static class UstawieaniaAtrapZTekstemWyrazenia<TKomorkaZTekstem> where TKomorkaZTekstem : IKomorkaZTekstem
    {
        internal static Action<TKomorkaZTekstem> DodawanieObslugiZmianyUstaw =>
            komorka => komorka.PropertyChanged += (sender, e) => { };
    }
}
