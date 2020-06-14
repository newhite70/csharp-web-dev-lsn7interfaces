using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            return x.Cost.CompareTo(y.Cost);
        }
    }
}