using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzielnik.ModelWidoku.Interfejsy.Inicjalizator
{
    public interface IInicjalizatorDlaFabrykaModelWidoku : IInicjalizatorFabrykaNaleznosci, IInicjalizatorFabrykaOsob, IInicjalizatorFabrykaTablicaOsob, IInicjalizatorFabrykaPolozeniaWTabeliNaleznosci
    {
    }

    public interface IInicjalizatorFabrykaPolozeniaWTabeliNaleznosci
    {
        IFabrykaPolozeniaWTabeliNaleznosci FabrykaPolozeniaWTabeliNaleznosci { get; }
    }
}
