using Dzielnik.Zasoby.Zdarzenia;

namespace Dzielnik.Model.Interfejsy
{
    /// <summary>
    /// Interfejs modelu dzielnika przeznaczony dla udostępniania publicznych zasobow modelowi widoku.
    /// </summary>
    public interface IModelDzielnikaDlaModelWidoku
    {
        event ObliczonaTabelaNaleznosci_ObslugaZdarzenia ObliczonaTabelNaleznocsci;
    }
}