using System;

using Dzielnik.ModelWidoku.Interfejsy.Komendy;

using Moq;
using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komendy
{
    public class Czy_ObliczKomenda_Execute
    {
        [Fact]
        public void Czy_Execute_Wykonuje()
        {
            //Ustal
            Mock<Action> naObliczKomendaAkcja = Stworz_ObliczKomendaAkcja_WeryfikalnyMock.Stworz_WeryfikalnyMock();

            IObliczKomenda komenda = Stworz_ObliczKomenda.Stworz(naObliczKomendaAkcja.Object);

            //Dzialaj
            komenda.Execute(default(object));

            //Asercja
            naObliczKomendaAkcja.Verify( x => x.Invoke(), Times.Once, "Komenda \"" + naObliczKomendaAkcja.GetType().ToString() + "\" nie wykonala przekazanej akcji"  );
        }
    }
}