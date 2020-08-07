using System;
using System.Linq.Expressions;
using System.Windows.Media;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    internal static class UstawieniaAtrapZTlemTekstuWyrazenia<TKomorkaZKolorowymTlemTekstu> where TKomorkaZKolorowymTlemTekstu : IKomorkaZKolorowymTlemTekstu
    {
        internal static Expression<Func<TKomorkaZKolorowymTlemTekstu, Brush>> KolorTlaUstaw =>
            komorka => komorka.KolorTla;
    }
}