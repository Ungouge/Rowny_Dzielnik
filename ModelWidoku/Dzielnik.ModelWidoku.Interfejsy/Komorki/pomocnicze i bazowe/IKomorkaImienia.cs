
namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs bazowy dla komorek zawierajacych wlasciwosc z tekstem imienia.
    /// </summary>
    public interface IKomorkaImienia: IKomorkaZTekstem
    {
        /// <summary>
        /// Zwraca tekst komorki imienia.
        /// </summary>
        new string Tekst { get; }
    }
}