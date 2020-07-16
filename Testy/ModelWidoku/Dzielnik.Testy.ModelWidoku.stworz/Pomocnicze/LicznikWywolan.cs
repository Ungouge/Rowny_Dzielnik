
namespace Dzielnik.Testy.ModelWidoku.Pomocnicze
{
    public class LicznikWywolan
    {
        public int Licznik { get; private set; } = 0;

        public void DodajWywolanie() => Licznik++;
    }
}
