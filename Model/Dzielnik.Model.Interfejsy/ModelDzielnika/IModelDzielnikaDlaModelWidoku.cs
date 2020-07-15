using System;

using Dzielnik.Zasoby.Zdarzenia;

namespace Dzielnik.Model.Interfejsy
{
    /// <summary>
    /// Interfejs modelu dzielnika przeznaczony dla udostępniania publicznych zasobow modelowi widoku.
    /// </summary>
    public interface IModelDzielnikaDlaModelWidoku
    {
        /// <summary>
        /// Obsluga zdarzenia na obliczenie tabeli naleznosci prze model.
        /// </summary>
        event EventHandler<ObliczonaTabelaNaleznosci_ArgumentZdarzenia> ObliczonaTabelNaleznocsci;
    }
}