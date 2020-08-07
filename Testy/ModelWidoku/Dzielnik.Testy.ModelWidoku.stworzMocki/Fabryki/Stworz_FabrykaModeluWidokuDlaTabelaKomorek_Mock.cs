using System.Collections.Generic;

using Dzielnik.ModelWidoku.Interfejsy.Fabryki;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Testy.Model.TabeleNaleznosci;
using Dzielnik.Testy.ModelWidoku.Komorki;
using Dzielnik.Testy.Zasoby.TabelaNaleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Fabryki
{
    public static partial class Stworz_FabrykaModeluWidokuDlaTabelaKomorek_Mock
    {
        internal static IFabrykaModeluWidokuDlaTabelaKomorek Stworz_StworzKomorki_Mock()
        {
            Mock<IFabrykaModeluWidokuDlaTabelaKomorek> fabryka_Mock = Stworz_MockWlasciwy();

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaDiagonalna(It.IsAny<IKomorkaImieniaINaleznosciWejscowej>())).
                Returns(Stworz_KomorkaDiagonalna_Mock.Stworz_Mock());

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaDolnotrojkatnaKwotyNaleznej(It.IsAny<IKomorkaKwotyNaleznej>())).
                Returns(Stworz_KomorkaDolnotrojkatnaKwotyNaleznej_Mock.Stworz_Mock());

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaGornotrojkatnaKwotyNaleznej(It.IsAny<IKomorkaKwotyNaleznej>())).
                Returns(Stworz_KomorkaGornotrojkatnaKwotyNaleznej_Mock.Stworz_Mock());

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaWejsciowaKwoty(It.IsAny<IKomorkaImieniaINaleznosciWejscowej>())).
                Returns(Stworz_KomorkaWejsciowaKwoty_Mock.Stworz_Mock());

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaWejsciowaImienia(It.IsAny<IKomorkaImieniaINaleznosciWejscowej>())).
                Returns(Stworz_KomorkaWejsciowaImienia_Mock.Stworz_Mock());

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaWyjsciowaImienia(It.IsAny<IKomorkaImieniaINaleznosciWejscowej>())).
                Returns(Stworz_KomorkaWyjsciowaImienia_Mock.Stworz_Mock());

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaKwotyNaleznej(It.IsAny<byte>(), It.IsAny<byte>(), It.IsAny<IKonwerterNaleznoscNaStringProkurent>())).
                Returns(Stworz_KomorkaKwotyNaleznej_Mock.Stworz_Mock());

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkiImieniaINaleznosciWejscowej(It.IsAny<byte>(), It.IsAny<IKonwerterTekstKwotyWejsciowejProkurent>())).
                Returns(Stworz_KomorkaImieniaINaleznosciWejscowej_Mock.Stworz_Mock());

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaListyKryteriumWyboru()).
                Returns(Stworz_KomorkaListyKryteriumWyboru_Mock.Stworz_Mock());

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaListyRodzajuNaleznosci()).
                Returns(Stowrz_KomorkaListyRodzajuNaleznosci_Mock.Stworz_Mock());

            return fabryka_Mock.Object;
        }

        internal static Mock<IFabrykaModeluWidokuDlaTabelaKomorek> Stworz_StworzKomorki_WeryfikowalnyMock()
        {
            Mock<IFabrykaModeluWidokuDlaTabelaKomorek> fabryka_Mock = Stworz_MockWlasciwy();

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaDiagonalna(It.IsAny<IKomorkaImieniaINaleznosciWejscowej>())).
                Verifiable();

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaDolnotrojkatnaKwotyNaleznej(It.IsAny<IKomorkaKwotyNaleznej>())).
                Verifiable();

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaGornotrojkatnaKwotyNaleznej(It.IsAny<IKomorkaKwotyNaleznej>())).
                Verifiable();

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaWejsciowaKwoty(It.IsAny<IKomorkaImieniaINaleznosciWejscowej>())).
                Verifiable();

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaWejsciowaImienia(It.IsAny<IKomorkaImieniaINaleznosciWejscowej>())).
                Verifiable();

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaWyjsciowaImienia(It.IsAny<IKomorkaImieniaINaleznosciWejscowej>())).
                Verifiable();

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaKwotyNaleznej(It.IsAny<byte>(), It.IsAny<byte>(), It.IsAny<IKonwerterNaleznoscNaStringProkurent>())).
                Verifiable();

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkiImieniaINaleznosciWejscowej(It.IsAny<byte>(), It.IsAny<IKonwerterTekstKwotyWejsciowejProkurent>())).
                Verifiable();

            return fabryka_Mock;
        }

        internal static IFabrykaModeluWidokuDlaTabelaKomorek Stworz_OsobyKomorekKwotyWejsciowej_Mock(out IList<IOsobaTypSwiadczenia> osobyLista)
        {
            Mock<IFabrykaModeluWidokuDlaTabelaKomorek> fabryka_Mock = Stworz_MockWlasciwy();

            osobyLista = new List<IOsobaTypSwiadczenia>();

            KomorkaZOsoba_ObslugaListy obslugaListyKomorek = new KomorkaZOsoba_ObslugaListy(osobyLista);

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkiImieniaINaleznosciWejscowej(It.IsAny<byte>(), It.IsAny<IKonwerterTekstKwotyWejsciowejProkurent>())).
                Returns(() => obslugaListyKomorek.StworzKomorkaZOsoba());

            return fabryka_Mock.Object;
        }

        internal static IFabrykaModeluWidokuDlaTabelaKomorek Stworz_NaleznosciKomorekKwotyWejsciowej_Mock(out IDictionary<IPolozenieWTabeliNaleznosci, INaleznoscSwiadczenieBaza> naleznosciSlownik)
        {
            Mock<IFabrykaModeluWidokuDlaTabelaKomorek> fabryka_Mock = Stworz_MockWlasciwy();

            naleznosciSlownik = new Dictionary<IPolozenieWTabeliNaleznosci, INaleznoscSwiadczenieBaza>();

            TabelaZNaleznoscia_ObslugaSlownika obslugaListyKomorek = new TabelaZNaleznoscia_ObslugaSlownika(naleznosciSlownik);

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzKomorkaKwotyNaleznej(It.IsAny<byte>(), It.IsAny<byte>(), It.IsAny<IKonwerterNaleznoscNaStringProkurent>())).
                Returns((byte indeks_X, byte indeks_Y, IKonwerterNaleznoscNaStringProkurent prokurent) =>
                Stworz_KomorkaKwotyNaleznej_Mock.Stworz_UstalNaleznosc_WeryfikowalnyMock(Stworz_PolozenieWTabeliNaleznosci_Mock.Stworz_IndeksyPolozenia_Mock(indeks_X, indeks_Y),
                    obslugaListyKomorek));

            return fabryka_Mock.Object;
        }

        internal static Mock<IFabrykaModeluWidokuDlaTabelaKomorek> Stworz_MockWlasciwy()
        {
            Mock<IFabrykaModeluWidokuDlaTabelaKomorek> fabryka_Mock = new Mock<IFabrykaModeluWidokuDlaTabelaKomorek>();

            return fabryka_Mock;
        }
    }
}