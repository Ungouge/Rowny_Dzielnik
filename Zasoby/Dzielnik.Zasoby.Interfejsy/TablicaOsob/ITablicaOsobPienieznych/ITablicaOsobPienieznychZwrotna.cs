using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.Interfejsy.TablicaOsob
{
    /// <summary>
    /// Interfejs bazowy dla tablic osob zwracajacych osobe ze swiadzceniem pienieznym o danym ID.
    /// </summary>
    public interface ITablicaOsobPienieznychZwrotna : ITablicaOsobZwrotna
    {
        new IOsobaPienieznaWymienna this[byte iD] { get; }
    }
}