using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla fasady fabryki do tworzenia potrzebnych obiektow dla NajlepszaWymianaNalezosciPienieznejZnajdywacz.
    /// </summary>
    internal interface IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywaczFasada
    {
        ITabelaNaleznosciPienieznej StworzStartowaTabelaNaleznosciPienieznej();

        ITabelaNaleznosciPienieznej StworzTabelaNaleznosciPienieznejNull();

        IPolozenieWTabeliNaleznosci StworzPolozenieWTabeliNaleznosci(byte index_X, byte index_Y);
    }
}