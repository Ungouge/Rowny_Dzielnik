using Dzielnik.ModelWidoku.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Dzielnik.UzytkownikaInterfejs
{
    /// <summary>
    /// Interaction logic for RownyDzielnik.xaml
    /// </summary>
    public partial class RownyDzielnik : Window
    {
        private readonly IModelWidokuDzielnika modelWidokuDzielnika;

        public RownyDzielnik(IModelWidokuDzielnika modelWidokuDzielnika)
        {
            this.modelWidokuDzielnika = modelWidokuDzielnika;

            DataContext = this.modelWidokuDzielnika;

            InitializeComponent();
        }
    }
}
