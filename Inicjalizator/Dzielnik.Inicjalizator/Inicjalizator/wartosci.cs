using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.Zasoby.Interfejsy;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzielnik.Inicjalizator
{
    partial class Inicjalizator
    {
        private readonly IUstawienia ustawienia;

        // Zasoby
        
        public IFabrykaNaleznoscPieniezna FabrykaNaleznoscPieniezna { get; }

        public IFabrykaTablicaOsobPienieznych FabrykaTablicaOsob { get; }
        
        public IFabrykaPolozeniaWTabeliNaleznosci FabrykaPolozeniaWTabeliNaleznosci { get; }

        public IFabrykaNaleznoscPienieznaZerowa FabrykaNaleznoscPienieznaZerowa { get; private set; }

        // Model

        public IAbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych AbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych { get; private set; }

        public IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci AbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci { get; private set; }

        public IFabrykaKryteriumWyboruTabeliNaleznosciPienieznychNull FabrykaKryteriumWyboruTabeliNaleznosciNull { get; private set; }
    }
}
