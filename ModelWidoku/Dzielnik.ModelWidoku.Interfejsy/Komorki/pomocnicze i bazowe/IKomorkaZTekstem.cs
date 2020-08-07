
namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs bazowy dla komorek zawierajacych wlasciwosc z tekstem.
    /// </summary>
    public interface IKomorkaZTekstem : IKomorkaZmienna
    {
        /// <summary>
        /// Zwraca tekst komorki.
        /// </summary>
        string Tekst { get; }
    }
}