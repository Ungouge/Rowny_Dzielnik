using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dzielnik.ModelWidoku;
using Dzielnik.ModelWidoku.Interfejsy;
using Dzielnik.Zasoby.Interfejsy;
using Dzielnik.Model.Interfejsy;
using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.ModelWidoku.Fabryki;
using Dzielnik.ModelWidoku.Interfejsy.Inicjalizator;

namespace Dzielnik.ModelWidoku.Inicjalizator
{
    public static class InicjalizatorModeluWidoku
    {
        private static IModelWidokuDzielnika instancjaModelWidoku = null;

        private static IFabrykaModelWidoku instancjaFabrykiModelWidoku = null;

        public static IModelWidokuDzielnika InitializujModelWidoku( IModelDzielnika modelDzielnika, IInicjalizatorDlaFabrykaModelWidoku inicjalizator, IUstawienia ustawienia)
        {
            instancjaFabrykiModelWidoku = InitializujFabrykaModelWidoku(modelDzielnika , inicjalizator, ustawienia);

            if (instancjaModelWidoku == null)
                instancjaModelWidoku = new ModelWidokuDzielnika(instancjaFabrykiModelWidoku, ustawienia, modelDzielnika,
                    instancjaFabrykiModelWidoku.StworzCzyMoznaObliczacWkaznik());

            return instancjaModelWidoku;
        }

        private static IFabrykaModelWidoku InitializujFabrykaModelWidoku
            (IModelDzielnikaDlaUaktualniaczModelu modelDzielnika, IInicjalizatorDlaFabrykaModelWidoku inicjalizator, IUstawienia ustawienia)
        {
            if (instancjaFabrykiModelWidoku == null)
                return new FabrykaModelWidoku(modelDzielnika, inicjalizator, ustawienia);// new TesktK;wotyWejsciowejNaNaleznoscKonwerter(inicjalizator.FabrykaNaleznoscPieniezna), new NaleznoscPienieznaNaStringKonwerter(),
                    //inicjalizator.FabrykaNaleznoscPieniezna, inicjalizator.FabrykaTablicaOsob,
                    //new CzyMoznaObliczacWkaznik(), new ModelUaktualniacz(modelDzielnika));

            return instancjaFabrykiModelWidoku;
        }
    }
}
