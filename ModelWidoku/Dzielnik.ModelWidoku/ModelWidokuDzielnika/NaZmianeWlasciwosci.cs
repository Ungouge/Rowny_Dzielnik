using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Dzielnik.ModelWidoku
{
    partial class ModelWidokuDzielnika : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NaZmianeWlasciwosci([CallerMemberName] string nazwaWlasciwosci = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nazwaWlasciwosci));
        }
    }
}