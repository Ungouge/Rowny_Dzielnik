using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.Interfejsy.TablicaOsob
{
    /// <summary>
    /// Interfejs bazowy dla tablic osob zwracajacych osobe ze swiadzceniem pienieznym o danym ID.
    /// </summary>
    public interface ITablicaOsobPienieznychZwrotna : ITablicaOsobZwrotna<IOsobaPieniezna>
    {
        new IOsobaPieniezna this[IOsobaID osobaID] { get; }
    }
}