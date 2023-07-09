using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class StackExample
    {
        //LIFO Order
        public void P6()
        {
            Stack<string> st = new Stack<string>();
            st.Push("Abhinav");
            st.Push("Vinay");
            st.Push("Naresh");
            st.Push("Nikhil");

            Console.WriteLine("***Stack***");
            foreach(string name in st)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek Element: "+st.Peek());
            Console.WriteLine("Pop Element: "+st.Pop());
            Console.WriteLine("After Pop, Peek Element: "+st.Peek());
        }
    }
}
