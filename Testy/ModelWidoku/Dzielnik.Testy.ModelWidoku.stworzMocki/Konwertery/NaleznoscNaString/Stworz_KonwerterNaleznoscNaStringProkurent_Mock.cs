using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Moq;
using System;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.NaleznoscNaString
{
    internal static class Stworz_KonwerterNaleznoscNaStringProkurent_Mock
    {
        internal static IKonwerterNaleznoscNaStringProkurent Stworz_NaString_Mock(string tekstZwrotny)
        {
            Mock<IKonwerterNaleznoscNaStringProkurent> prokurtent_Mock = new Mock<IKonwerterNaleznoscNaStringProkurent>();

            prokurtent_Mock.
                Setup(prokurent => prokurent.NaString(It.IsAny<INaleznoscSwiadczenieBaza>())).
                Returns(tekstZwrotny.ToLower());

            prokurtent_Mock.
                Setup(prokurent => prokurent.NaStringOdwrotnosc(It.IsAny<INaleznoscSwiadczenieBaza>())).
                Returns(tekstZwrotny.ToUpper());

            return prokurtent_Mock.Object;
        }

        internal static Mock<IKonwerterNaleznoscNaStringProkurent> Stworz_NaString_WeryfikowalnyMock(INaleznoscSwiadczenieBaza oczekiwanaNaleznosc, string naString, string naStringOdwrotnosc)
        {
            Mock<IKonwerterNaleznoscNaStringProkurent> prokurtent_Mock = new Mock<IKonwerterNaleznoscNaStringProkurent>();

            prokurtent_Mock.
                Setup(prokurent => prokurent.NaString(It.IsAny<INaleznoscSwiadczenieBaza>())).
                Returns((INaleznoscSwiadczenieBaza naleznosc) => oczekiwanaNaleznosc == naleznosc ? naString : String.Empty).
                Verifiable();

            prokurtent_Mock.
                Setup(prokurent => prokurent.NaStringOdwrotnosc(It.IsAny<INaleznoscSwiadczenieBaza>())).
                Returns((INaleznoscSwiadczenieBaza naleznosc) => oczekiwanaNaleznosc == naleznosc ? naStringOdwrotnosc : String.Empty).
                Verifiable();

            return prokurtent_Mock;
        }
    }
}
