using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Zasoby.Fabryki
{
    /// <summary>
    /// Abstrakcyjna fabryka dla tabel naleznosci pieniezncyh do tworzenia naleznosci w zaleznosci od polozenia w tabeli.
    /// </summary>
    public class AbstrakcyjnaFabrykaNaleznosciPienieznejDlaTabeliNaleznosci : IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci
    {
        private readonly IFabrykaNaleznoscPienieznaDiagonalna fabrykaNaleznoscPienieznaDiagonalna;

        private readonly IFabrykaNaleznoscPienieznaZerowa fabrykaNaleznoscPienieznaZerowa;

        public AbstrakcyjnaFabrykaNaleznosciPienieznejDlaTabeliNaleznosci
            (IFabrykaNaleznoscPienieznaDiagonalna fabrykaNaleznoscPienieznaDiagonalna, IFabrykaNaleznoscPienieznaZerowa fabrykaNaleznoscPienieznaZerowa)
        {
            this.fabrykaNaleznoscPienieznaDiagonalna = fabrykaNaleznoscPienieznaDiagonalna;

            this.fabrykaNaleznoscPienieznaZerowa = fabrykaNaleznoscPienieznaZerowa;
        }

        public INaleznoscPienieznaSwiadczenie StworzNaleznoscPienieznaZwrotna(IPolozenieGornotrojkatneWTabeliNaleznosci polozenieWTabeli)
        {
            if (polozenieWTabeli.CzyKoordynatyDiagonalne == true)
                return fabrykaNaleznoscPienieznaDiagonalna.StworzNaleznoscDiagonalna();

            return StworzNaleznoscPienieznaZerowa();
        }

        public INaleznoscPieniezna StworzNaleznoscPienieznaZerowa()
        {
            return fabrykaNaleznoscPienieznaZerowa.StworzNaleznoscZerowa();
        }
    }
}