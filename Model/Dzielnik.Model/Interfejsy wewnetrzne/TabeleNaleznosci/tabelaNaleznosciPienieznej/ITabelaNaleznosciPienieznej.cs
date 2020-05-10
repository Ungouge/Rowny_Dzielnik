using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model.Interfejsy.TabeleNaleznosci
{
    /// <summary>
    /// Interfejs dla dwuwymiarowych tabel zawierajacych naleznosci swiadczeń wyrazona w walucie podzielnej na setki osobom względem siebie.
    /// </summary>
    internal interface ITabelaNaleznosciPienieznej: ITabelaNaleznosciPienieznejZwrotna
    {
        /// <summary>
        /// Zwraca kryterium wyboru tabeli naleznosci pienieznej odpowiadjace wymianom naleznosci w tabeli wybranego typu kryterium naleznosci pienieznej.
        /// </summary>
        IKryteriumWyboruTabeliNaleznosciPienieznej KryteriumWyboruTabeliNaleznosci { get; }
        
        /// <summary>
        /// Zwaraca tabele posiadajaca lepsze kryterium sposrod dwoch do wyboru. 
        /// </summary>
        ITabelaNaleznosciPienieznej ZwrocLepszeKryterium(ITabelaNaleznosciPienieznej porownywanaTabela);

        /// <summary>
        /// Dodaje podana wymiane naleznosci w podanym polozeniu.
        /// </summary>
        void DodajWymianeNalzenosciUaktualniajacKryterium(INaleznoscPieniezna naleznosc,
            IPolozenieGornotrojkatneWTabeliNaleznosci polozenieWTabeli);
    }
}