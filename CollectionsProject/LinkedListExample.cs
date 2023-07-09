using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class LinkedListExample
    {
        public static void P4()
        {
            var names = new LinkedList<String>();
            names.AddLast("Bhuvan");
            names.AddLast("Charan");
            names.AddFirst("Abhinav");
            names.AddLast("Deepak");
            names.AddLast("Charan");

            Console.WriteLine("***LinkedList***");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
