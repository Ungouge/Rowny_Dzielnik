using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.Model.Inicjalizator;
using Dzielnik.Model.Interfejsy;
using Dzielnik.ModelWidoku.Inicjalizator;
using Dzielnik.ModelWidoku.Interfejsy;
using Dzielnik.UzytkownikaInterfejs;
using Dzielnik.Zasoby.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Fabryki;

namespace Dzielnik.Inicjalizator
{
    public partial class Inicjalizator: IInicjalizator
    {
        public IFabrykaOsobaPieniezna FabrykaOsobaPieniezna { get; }

        private Inicjalizator(IUstawienia ustawienia)
        {
            this.ustawienia = ustawienia;

            FabrykaNaleznoscPieniezna = new FabrykaNaleznoscPieniezna();

            IFabrykaOsobaPieniezna fabrykaOsoba = new FabrykaOsobaPieniezna();

            FabrykaTablicaOsob = new FabrykaTablicaOsobPienieznych();

            IFabrykaNaleznoscPienieznaZerowa fabrykaNaleznoscPienieznaZerowa = new FabrykaNaleznoscPienieznaZerowa();

            IFabrykaNaleznoscPienieznaDiagonalna fabrykaNaleznoscDiagonalna = new FabrykaNaleznoscPienieznaDiagonalna();

            IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci =
                new AbstrakcyjnaFabrykaNaleznosciPienieznejDlaTabeliNaleznosci(fabrykaNaleznoscDiagonalna, fabrykaNaleznoscPienieznaZerowa);

            IFabrykaKryteriumWyboruTabeliNaleznosciPienieznychNull fabrykaKryteriumWyboruTabeliNaleznosciPienieznychNull = new FabrykaKryteriumWyboruTabeliNaleznosciPienieznychNull();

            FabrykaOsobaPieniezna = new FabrykaOsobaPieniezna();

            FabrykaPolozeniaWTabeliNaleznosci = new FabrykaPolozeniaWTabeliNaleznosci();

            //inicjaizacja dla modelu

            AbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych =
                new AbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych(fabrykaNaleznoscPienieznaZerowa);

            AbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci =
                new AbstrakcyjnaFabrykaNaleznosciPienieznejDlaTabeliNaleznosci(fabrykaNaleznoscDiagonalna, fabrykaNaleznoscPienieznaZerowa);

            FabrykaKryteriumWyboruTabeliNaleznosciNull = new FabrykaKryteriumWyboruTabeliNaleznosciPienieznychNull();

            FabrykaNaleznoscPienieznaZerowa = new FabrykaNaleznoscPienieznaZerowa();
        }

        public RownyDzielnik StworzWidokDzielnika()
        {
            return new RownyDzielnik(StworzModelWidokuDzielnika());
        }

        private IModelWidokuDzielnika StworzModelWidokuDzielnika()
        {
            return InicjalizatorModeluWidoku.InitializujModelWidoku(StworzModelDzielnika(), this, ustawienia);
        }

        private IModelDzielnika StworzModelDzielnika()
        {
            return InicjalizatorModelu.InicjalizujModelu(this, ustawienia);
        }
    }
}
