using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class SortedSetExample
    {
        public static void P2() 
        {
            var names = new SortedSet<string>();
            names.Add("Bhuvan");
            names.Add("Deepak");
            names.Add("Abhinav");
            names.Add("Charan");

            Console.WriteLine("***SortedSet***");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
