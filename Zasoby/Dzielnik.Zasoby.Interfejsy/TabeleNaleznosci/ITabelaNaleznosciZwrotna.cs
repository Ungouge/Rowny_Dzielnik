using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci
{
    public interface ITabelaNaleznosciZwrotna: ITabelaNaleznosciBaza
    {
        INaleznoscSwiadczenieBaza this[IPolozenieWTabeliNaleznosci polozenieWTabeli] { get; }
    }
}