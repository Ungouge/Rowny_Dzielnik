using Dzielnik.Zasoby.Interfejsy.Osoby;

using Moq;

namespace Dzielnik.Testy.Zasoby.Osoby
{
    public static class Stworz_OsobaID_Moq
    {
        public static IOsobaID Stworz_ID_Moq(byte iD)
        {
            Mock<IOsobaID> osobaID = new Mock<IOsobaID>();

            osobaID.
                Setup(i => i.ID).
                Returns(iD);

            return osobaID.Object;
        }
    }
}