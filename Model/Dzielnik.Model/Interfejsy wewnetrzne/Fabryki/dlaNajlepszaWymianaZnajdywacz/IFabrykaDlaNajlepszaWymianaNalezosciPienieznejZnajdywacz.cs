using Dzielnik.Model.Interfejsy.DoStanuKwitaSumator;
using Dzielnik.Model.Interfejsy.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz;
using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla fabryki do tworzenia potrzebnych obiektow dla NajlepszaWymianaNalezosciPienieznejZnajdywacz.
    /// </summary>
    internal interface IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz
    {
        ITabelaNaleznosciPienieznej StworzStartowaTabelaNaleznosciPienieznej();

        ITabelaNaleznosciPienieznej StworzTabelaNaleznosciPienieznejNull();

        IPolozenieWTabeliNaleznosci StworzPolozenieWTabeliNaleznosci(byte index_X, byte index_Y);
    }
}