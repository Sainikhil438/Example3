using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class ListExample
    {
        public static void P3()
        {
            var names = new List<string>();
            names.Add("Abhinav");
            names.Add("Charan");
            names.Add("Bhuvan");
            names.Add("Deepak");
            names.Add("Abhinav");

            Console.WriteLine("***List***");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
