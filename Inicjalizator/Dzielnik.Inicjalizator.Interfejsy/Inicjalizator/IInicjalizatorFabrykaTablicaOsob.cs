using Dzielnik.Zasoby.Interfejsy;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzielnik.Inicjalizator.Interfejsy
{
    public interface IInicjalizatorFabrykaTablicaOsob
    {
        IFabrykaTablicaOsobPienieznych FabrykaTablicaOsob { get; }
    }
}
