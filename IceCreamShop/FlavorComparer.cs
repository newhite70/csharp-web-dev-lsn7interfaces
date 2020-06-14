using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {
        public enum SortBy
        {
            Name,
            Allergens
        }
        private SortBy compareField = SortBy.Allergens;
        public int Compare([AllowNull] Flavor x, [AllowNull] Flavor y)
        {

            
            switch (compareField)
            {
                case SortBy.Name:
                    return x.Name.CompareTo(y.Name);
                    //break;
                case SortBy.Allergens:
                    return x.Allergens.Count.CompareTo(y.Allergens.Count);
                    //break;
                default:
                    break;
            }

            return string.Compare(x.Name, y.Name);
        }
    }
}
