﻿using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Zasoby.KryteriumWyboru
{
    partial class KryteriumIlosciWymian
    {
        public override bool CzyPorownywaneKyrteriumLepsze(IKryteriumWyboruTabeliNaleznosciPienieznej porownywaneKryterium)
        {
            if (porownywaneKryterium is IKryteriumIlosciWymian porownywaneKryteriumIlosciWymian)
                if (this.WezIlosciWymian >= porownywaneKryteriumIlosciWymian.WezIlosciWymian)
                    return base.CzyPorownywaneKyrteriumLepsze(porownywaneKryteriumIlosciWymian);

            return false;
        }
    }
}