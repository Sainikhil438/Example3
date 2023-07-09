using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class SortedDictionaryExample
    {
       public void P9()
        {
            SortedDictionary<string, string> sd = new SortedDictionary<string, string>();
            sd.Add("3", "Naresh");
            sd.Add("4", "Manihar");
            sd.Add("5", "Nikhil");
            sd.Add("1", "Abhinav");
            sd.Add("2", "Vinay");

            Console.WriteLine("***SortedDictionary***");
            foreach(KeyValuePair<string,string> kv in sd)
            {
                Console.WriteLine(kv.Key+"."+kv.Value);
            }
        }
    }
}
