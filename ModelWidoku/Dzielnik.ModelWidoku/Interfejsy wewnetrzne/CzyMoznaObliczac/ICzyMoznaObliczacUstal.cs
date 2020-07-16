using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac
{
    /// <summary>
    /// Interfejs dla wskaznika wskazujacego czy mozna obliczac ze zmiany moznosci oblcizania.
    /// </summary>
    interface ICzyMoznaObliczacWkaznikUstal
    {
        /// <summary>
        /// Zmienia zapamietany status komorki i w warazie potrzeby zmienia status wskaznika popychajac dalej wynikle z tego zmiany w programie.
        /// </summary>
        void ZmienMozliwoscOblicznia(IKomorkaWejsciowaKwoty komorkaKwotyWejsciowej, bool czyPozwalam);
    }
}