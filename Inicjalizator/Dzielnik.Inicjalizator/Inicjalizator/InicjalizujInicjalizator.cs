using Dzielnik.Inicjalizator.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzielnik.Inicjalizator
{
    partial class Inicjalizator
    {
        private static bool czyInicjalizowane = false;

        public static IInicjalizatorDzielnika InicjalizujInicjalizator(IUstawienia ustawienia)
        {
            if (czyInicjalizowane == true)
                throw new ApplicationException("Proba ponownej inicjalizacji inicjalizatora, jest niedozwolona");

            czyInicjalizowane = true;

            return new Inicjalizator(ustawienia);
        }
    }
}
