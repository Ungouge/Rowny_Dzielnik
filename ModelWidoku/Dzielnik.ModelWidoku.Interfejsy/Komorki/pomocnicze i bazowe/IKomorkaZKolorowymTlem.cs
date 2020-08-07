using System.Windows.Media;

namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs bazowy dla komorek zawierajacych wlasciwosc z kolorem tla.
    /// </summary>
    public interface IKomorkaZKolorowymTlem: IKomorkaZmienna
    {
        /// <summary>
        /// Zwraca kolor tla.
        /// </summary>
        Brush KolorTla { get; }
    }
}