using System;
using System.Collections.Generic;

using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.ModelWidoku
{
    partial class ModelWidokuDzielnika
    {
        public IEnumerable<RodzajNaleznosciWylicznik> RodzajNaleznosciLista
        {
            get
            {
                foreach (RodzajNaleznosciWylicznik kryterium in
                    (RodzajNaleznosciWylicznik[])Enum.GetValues(typeof(RodzajNaleznosciWylicznik)))
                {
                    yield return kryterium;
                }
            }
        }

        //public IList<RodzajNaleznosciWylicznik> RodzajNaleznosciLista
        //{
        //    get
        //    {
        //        return IterujRodzajNaleznosciWylicznik().ToList();
        //    }
        //}

        //private IEnumerable<RodzajNaleznosciWylicznik> IterujRodzajNaleznosciWylicznik()
        //{
        //    foreach (RodzajNaleznosciWylicznik kryterium in
        //        (RodzajNaleznosciWylicznik[])Enum.GetValues(typeof(RodzajNaleznosciWylicznik)))
        //    {
        //        yield return kryterium;
        //    }
        //}
    }
}
