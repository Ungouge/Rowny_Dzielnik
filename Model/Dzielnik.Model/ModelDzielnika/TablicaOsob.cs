using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model
{
    partial class ModelDzielnika
    {
        private ITablicaOsobBaza tablicaOsob;

        public ITablicaOsobBaza TablicaOsob
        {
            get
            {
                return tablicaOsob;
            }
            set
            {
                if (value != tablicaOsob)
                {
                    tablicaOsob = value;

                    czyModelZostalUaktualniony = true;
                }
            }
        }
    }
}