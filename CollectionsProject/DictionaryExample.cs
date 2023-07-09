using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class DictionaryExample
    {
        public void P8()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("1", "Abhinav");
            dic.Add("2", "Vinay");
            dic.Add("3", "Naresh");
            dic.Add("4", "Nikhil");

            Console.WriteLine("***Dictionary***");
            foreach(KeyValuePair<string,string> kv in dic)
            {
                Console.WriteLine(kv.Key+"."+kv.Value);
            }
        }
    }
}
