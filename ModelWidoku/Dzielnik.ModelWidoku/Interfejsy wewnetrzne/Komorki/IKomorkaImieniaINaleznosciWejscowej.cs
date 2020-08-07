
namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs dla adaptowalnej zbiorczej komorki imienia oraz kwoty wejsciowej
    /// </summary>
    internal interface IKomorkaImieniaINaleznosciWejscowej: IKomorkaWyjsciowaImienia, IKomorkaWejsciowaImienia, IKomorkaOsobyWejsciowej, IKomorkaDiagonalna
    {
    }
}