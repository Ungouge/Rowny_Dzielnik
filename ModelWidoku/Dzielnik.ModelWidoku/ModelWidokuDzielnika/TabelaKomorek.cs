using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku
{
    partial class ModelWidokuDzielnika
    {
        private ITabelaKomorek tabelaKomorek;

        public ITabelaKomorekZwrotna TabelaKomorek
        {
            get
            {
                return tabelaKomorek;
            }
        }
    }
}
