using System;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komendy
{
    internal static class Stworz_ObliczKomendaAkcja_WeryfikalnyMock
    {
        internal static Mock<Action> Stworz_WeryfikalnyMock()
        {
            Mock<Action> naObliczKomendaAkcja = new Mock<Action>();

            naObliczKomendaAkcja.
                Setup
                (
                    akcja => akcja.Invoke()
                ).Verifiable();

            return naObliczKomendaAkcja;
        }
    }
}
