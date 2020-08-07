
namespace Dzielnik.ModelWidoku.Komorki
{
    partial class TabelaKomorek
    {
        private void UsunOsobe()
        {
            // Czeka na zaimlementowanie zmiany ilosci osob.
            komorkiDolnotrojkatnaKwotyNaleznej.Pop();

            komorkiGornotrojkatnaKwotyNaleznej.Pop();

            komorkiKwotyNaleznej.Pop();

            komorkiImieniaINaleznosciWejscowej.Pop();

            komorkiDiagonalna.Pop();

            komorkiKwotyWejsciowej.Pop();

            komorkiWejsciowaImienia.Pop();

            komorkiWyjsciowaImienia.Pop();
        }
    }
}