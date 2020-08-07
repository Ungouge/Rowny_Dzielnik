
namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs bazowy dla komorek zawierajacych wlasciwosc z modyfikowalnym tekstem.
    /// </summary>
    public interface IKomorkaZWejsciemTekstu : IKomorkaZTekstem
    {
        /// <summary>
        /// Zwraca iterator rzedu tabeli w którym powinna znajdować się komorka z modyfikowalnym tekstem.
        /// </summary>
        new byte Rzad { get; }
        
        /// <summary>
        /// Zwraca i przypisuje tekst komorki.
        /// </summary>
        new string Tekst { get; set; }
    }
}