using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.

            foreach (Flavor i in availableFlavors)
            {
                Console.WriteLine($"{i.Name}");
            }
            FlavorComparer comparer = new FlavorComparer();
            availableFlavors.Sort(comparer);
            
            foreach (Flavor i in availableFlavors)
            {
                Console.WriteLine($"{i.Name}");
            }


            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            foreach (Cone i in availableCones)
            {
                Console.WriteLine($"{i.Name}: {i.Cost}");
            }
            availableCones.Sort(new ConeComparer());


            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
            
            foreach (Cone i in availableCones)
            {
                Console.WriteLine($"{i.Name}: {i.Cost}");
            }
        }
    }
}
