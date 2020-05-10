﻿using System.Collections.Generic;

using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Testy.Zasoby.Osoby.OsobaPieniezna;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

using Moq;

namespace Dzielnik.Testy.Zasoby.TabliceOsob
{
    public static class Stworz_TablicaOsobPienieznych_Mock
    {
        public static ITablicaOsobPienieznychIterowalna Stworz_GetEnumerator_Mock_Swiadczenie_Mock(int[] swiadczeniaPieniezne)
        {
            Mock<ITablicaOsobPienieznychIterowalna> tablicaOsobOczekiwane = new Mock<ITablicaOsobPienieznychIterowalna>();

            tablicaOsobOczekiwane.
                Setup(x => x.GetEnumerator()).
                Returns(WyliczAtrapyOsob(swiadczeniaPieniezne));

            return tablicaOsobOczekiwane.Object;
        }

        private static IEnumerator<IOsobaPieniezna> WyliczAtrapyOsob(int[] NaleznosciPieniezneWGroszach)
        {
            for (byte iD = 0; iD < NaleznosciPieniezneWGroszach.Length; iD++)
            {
                INaleznoscPieniezna naleznoscPieniezna = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Swiadczenie_Mock(NaleznosciPieniezneWGroszach[iD]);

                IOsobaPieniezna osobaAtrapa = Stworz_OsobaPieniezna_Mock.Stworz_Wpalta_ID_Mock(naleznoscPieniezna, iD);

                yield return osobaAtrapa;
            }
        }

        public static ITablicaOsobPienieznych Stworz_GetEnumerator_WezIloscOsob_Mock(int[] swiadczeniaPieniezne)
        {
            Mock<ITablicaOsobPienieznych> tablicaOsobOczekiwane = new Mock<ITablicaOsobPienieznych>();

            tablicaOsobOczekiwane.
                Setup(x => x.GetEnumerator()).
                Returns(WyliczOsoby(swiadczeniaPieniezne));

            tablicaOsobOczekiwane.
                Setup(x => x.WezIloscOsob).
                Returns((byte)swiadczeniaPieniezne.Length);

            return tablicaOsobOczekiwane.Object;
        }

        private static IEnumerator<IOsobaPieniezna> WyliczOsoby(int[] NaleznosciPieniezneWGroszach)
        {
            for (byte iD = 0; iD < NaleznosciPieniezneWGroszach.Length; iD++)
            {
                INaleznoscPieniezna naleznoscPieniezna = Stworz_NaleznoscPieniezna.Stworz(NaleznosciPieniezneWGroszach[iD]);

                IOsobaPieniezna osobaAtrapa = Stworz_OsobaPieniezna_Mock.Stworz_Wpalta_ID_Mock(naleznoscPieniezna, iD);

                yield return osobaAtrapa;
            }
        }
    }
}       