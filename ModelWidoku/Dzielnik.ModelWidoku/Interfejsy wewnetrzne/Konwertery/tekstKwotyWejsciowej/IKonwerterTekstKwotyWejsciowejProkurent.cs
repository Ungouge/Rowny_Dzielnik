
namespace Dzielnik.ModelWidoku.Interfejsy.Konwertery
{
    /// <summary>
    /// Interfejs dla prokurenta konwerterow tekstu z komorki kwoty wejsciowe na odpowiedni typ nalznosci.
    /// </summary>
    internal interface IKonwerterTekstKwotyWejsciowejProkurent : IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka
    {
        /// <summary>
        /// Uaktualnij implentacje konwertera ktora bedzie prokurowana.
        /// </summary>
        void UaktualnijProkurent(ITekstKwotyWejsciowejKonwerter walidator);
    }
}