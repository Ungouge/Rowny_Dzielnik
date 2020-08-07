using Dzielnik.Model.Interfejsy;
using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Fabryki;
using Dzielnik.Model.Interfejsy.Inicjalizator;

namespace Dzielnik.Model.Inicjalizator
{
    public static class InicjalizatorModelu
    {
        private static IModelDzielnika instancjaModelu = null;

        private static IFabrykaModelu instancjaFabrykiModelu = null;

        private static IInicjaliztorDlaModelu inicjalizator = null;

        private static IUstawienia ustawienia = null;
        
        public static IModelDzielnika InicjalizujModelu(IInicjaliztorDlaModelu inicjalizatorDlaModelu, IUstawienia _ustawienia)
        {
            inicjalizator = inicjalizatorDlaModelu;

            ustawienia = _ustawienia;

            InitializujFabrykaModelu();

            if (instancjaModelu == null)
                instancjaModelu = new ModelDzielnika(instancjaFabrykiModelu);

            return instancjaModelu;
        }

        private static void InitializujFabrykaModelu()
        {
            if (instancjaFabrykiModelu == null)
                instancjaFabrykiModelu = new FabrykaModelu(inicjalizator);
        }

        internal static IFabrykaTabelaNalezosciPienieznej FabrykaTabelaNalezosciPienieznej
        {
            get
            {
                return new FabrykaTabelaNalezosciPienieznej(inicjalizator.AbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych,
                    inicjalizator.AbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci);
            }
        }

        internal static IFabrykaTabelaNalezosciPienieznejNull FabrykaTabelaNalezosciPienieznejNull
        {
            get
            {
                return new FabrykaTabelaNalezosciPienieznejNull(inicjalizator.FabrykaKryteriumWyboruTabeliNaleznosciNull,
                    inicjalizator.AbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci);
            }
        }
    }
}