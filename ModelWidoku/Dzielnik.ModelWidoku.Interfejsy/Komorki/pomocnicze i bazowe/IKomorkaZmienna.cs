using System.ComponentModel;

namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs bazowy dla komorek zawierajacych wlasciwosci ktore moga ulegac zmiania w czasie rzeczywistym.
    /// </summary>
    public interface IKomorkaZmienna : IKomorka, INotifyPropertyChanged
    {
    }
}