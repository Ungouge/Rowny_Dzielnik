using System;
using System.Collections.Generic;

using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.ModelWidoku
{
    partial class ModelWidokuDzielnika
    {
        public IEnumerable<KryteriumWyboruTabeliNaleznosciWylicznik> KryteriumWyboruLista
        {
            get
            {
                return (KryteriumWyboruTabeliNaleznosciWylicznik[]) Enum.GetValues(typeof(KryteriumWyboruTabeliNaleznosciWylicznik));
                //foreach (KryteriumWyboruTabeliNaleznosciWylicznik kryterium in
                //    (KryteriumWyboruTabeliNaleznosciWylicznik[])Enum.GetValues(typeof(KryteriumWyboruTabeliNaleznosciWylicznik)))
                //{
                //    yield return kryterium;
                //}
            }
        }
        //{
        //    public IList<KryteriumWyboruTabeliNaleznosciWylicznik> KryteriumWyboruLista
        //    {
        //        get
        //        {
        //            return IterujKryteriumWyboruTabeliNaleznosciWylicznik().ToList();
        //        }
        //    }

        //    private IEnumerable<KryteriumWyboruTabeliNaleznosciWylicznik> IterujKryteriumWyboruTabeliNaleznosciWylicznik()
        //    {
        //        foreach (KryteriumWyboruTabeliNaleznosciWylicznik kryterium in
        //            (KryteriumWyboruTabeliNaleznosciWylicznik[])Enum.GetValues(typeof(KryteriumWyboruTabeliNaleznosciWylicznik)))
        //        {
        //            yield return kryterium;
        //        }
        //    }
        }
}
