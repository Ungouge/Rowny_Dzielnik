using Dzielnik.Zasoby.Interfejsy.Fabryki;

namespace Dzielnik.Model.Interfejsy.Inicjalizator
{
    /// <summary>
    /// Interfejs inicjalizotora modelu.
    /// </summary>
    public interface IInicjaliztorDlaModelu : IInicjaliztorDlaFabrykaModelu
    {
        IAbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych AbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych { get; }

        IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci AbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci { get; }

        IFabrykaKryteriumWyboruTabeliNaleznosciPienieznychNull FabrykaKryteriumWyboruTabeliNaleznosciNull { get; }
    }
}
