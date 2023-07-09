using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class HashSetExample
    {
        //var can hold any data types implicitly
        public static void P1()
        {
            var names = new HashSet<string>();
            names.Add("Abhinav");
            names.Add("Bhuvan");
            names.Add("Charan");
            names.Add("Deepak");

            Console.WriteLine("***HashSet***");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
