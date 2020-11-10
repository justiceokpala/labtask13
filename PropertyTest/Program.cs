using System;
using System.Collections.Generic;
namespace PropertyTest
{
    class Program
    {
        static void Main(string[] args)
        {
           House house = new House("jos",false,21, 0.09M);
           House house1 = new House("plateau",false,23, 0.17M);
           House house2 = new House("aba",false,31, 0.30M);

           Bus bus = new Bus(67,9855, 9000M);
           Bus bus1 = new Bus(75,7495, 8400M);
           Bus bus2= new Bus(70,6555, 9000M);

            List<ITaxable> taxables = new List<ITaxable>(){house, house1, house2, bus, bus1, bus2};

              Console.WriteLine("\nAll Taxables Processed Polymorphically\n");

            foreach (ITaxable taxable in taxables)
            {
                Console.WriteLine(taxable.TaxValue());
            }
        }
    }
}

