using System;
using System.Windows;

using Dzielnik.UzytkownikaInterfejs;
using Dzielnik.Inicjalizator.Interfejsy;

namespace Dzielnik
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Dzielnik : Application
    {
        [STAThread]
        public static void Main(string[] args)
        {
            IUstawienia ustawienia = OdczytajUstawienia;

            IInicjalizatorDzielnika inicjalizator = Inicjalizator.Inicjalizator.InicjalizujInicjalizator(ustawienia);

            RownyDzielnik dzielnik = inicjalizator.StworzWidokDzielnika();

            Dzielnik Rowny_Dzielnik = new Dzielnik();

            Rowny_Dzielnik.Run(dzielnik);
        }
    }
}
