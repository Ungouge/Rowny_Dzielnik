using System;

using Dzielnik.ModelWidoku.Zdarzenia;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Zdarzenia
{
    internal static class Stworz_ZmianaStatusuMozliwosciObliczania_ObslugaZdarzenia_Mock
    {
        internal static Mock<EventHandler<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia>> Stworz_WeryfikalnyMock()
        {
            Mock<EventHandler<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia>> obslugaZdarzenia = new Mock<EventHandler<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia>>(); ;

            obslugaZdarzenia.
                Setup(x => x(It.IsAny<object>(), It.IsAny<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia>())).
                Verifiable();

            return obslugaZdarzenia;
        }
    }
}