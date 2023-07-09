using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class SortedListExample
    {
        public void P5()
        {
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("2", "Bhuvan");
            sl.Add("4", "Deepak");
            sl.Add("1", "Abhinav");
            sl.Add("5", "Nikhil");
            sl.Add("3", "Charan");

            Console.WriteLine("***SortedList***");
            foreach(KeyValuePair<string,string> kv in sl)
            {
                Console.WriteLine(kv.Key+"."+kv.Value);
            }
        }
    }
}
