using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    /// <summary>
    /// Abstrakcyjna klasa bazowa dla komorek.
    /// </summary>
    internal abstract class KomorkaBaza : IKomorka
    {
        // wartosci zwracane w przypadku zlej implementacji interfejsow pochodnych.
        public virtual byte Rzad => 0;

        public virtual byte Kolumna => 0;
    }
}