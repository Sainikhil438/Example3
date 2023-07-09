using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class QueueExample
    {
        //FIFO Order
        public void P7()
        {
            Queue<string> qu = new Queue<string>();
            qu.Enqueue("Abhinav");
            qu.Enqueue("Nikhil");
            qu.Enqueue("Vinay");
            qu.Enqueue("Naresh");

            Console.WriteLine("***Queue***");
            foreach(string name in qu)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek Element: " + qu.Peek());
            Console.WriteLine("Dequeue Element: "+qu.Dequeue());
            Console.WriteLine("After Dequeue: "+qu.Peek());
        }
    }
}
