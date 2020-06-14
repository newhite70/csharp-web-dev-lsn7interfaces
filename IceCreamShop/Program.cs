using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;
            FlavorComparer comparer = new FlavorComparer();
            availableFlavors.Sort(comparer);
            availableCones.Sort(new ConeComparer());

            availableFlavors.ForEach(Console.WriteLine);
            availableCones.ForEach(Console.WriteLine);

            availableFlavors.Sort(new FlavorComparer());
            availableFlavors.ForEach(Console.WriteLine);


            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
        }
    }
}
