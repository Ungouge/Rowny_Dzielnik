using Dzielnik.Model.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model.Fabryki
{
    partial class FabrykaModelu
    {
        public ITabelaNaleznosciPienieznej StworzTabelaNaleznosciPienieznejNull(byte iloscOsob)
        {
            return fabrykaTabelaNalezosciPienieznejNull.StworzTabelaNaleznosciPienieznejNull(iloscOsob);
        }
    }
}