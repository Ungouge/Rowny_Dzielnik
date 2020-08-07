using System.Collections.Generic;

using Dzielnik.ModelWidoku.Interfejsy.Komendy;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.ModelWidoku.Interfejsy
{
    public interface IModelWidokuDzielnika
    {
        IObliczKomenda ObliczKomenda { get; }

        IEnumerable<RodzajNaleznosciWylicznik> RodzajNaleznosciLista { get; }

        IEnumerable<KryteriumWyboruTabeliNaleznosciWylicznik> KryteriumWyboruLista { get; }

        KryteriumWyboruTabeliNaleznosciWylicznik WybraneKryteriumWyboru { get; set; }

        RodzajNaleznosciWylicznik WybranyRodzajNaleznosci { get; set; }

        ITabelaKomorekZwrotna TabelaKomorek { get; }

        int ElementSzerokosc { get; }

        int ElementWysokosc { get; }

        double OknoMaksymalnaWysokosc { get; }

        double OknoMaksymalnaSzerokosc { get; }

        int CzcionkaRozmiar { get; }
    }
}