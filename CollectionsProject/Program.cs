namespace CollectionsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    HashSetExample.P1();
                    break;
                case 2:
                    SortedSetExample.P2();
                    break;
                case 3:
                    ListExample.P3();
                    break;
                case 4:
                    LinkedListExample.P4();
                    break;
                case 5:
                    SortedListExample sle = new SortedListExample();
                    sle.P5();
                    break;
                case 6:
                    StackExample se = new StackExample();
                    se.P6();
                    break;
                case 7:
                    QueueExample qe = new QueueExample();
                    qe.P7();
                    break;
                case 8:
                    DictionaryExample de = new DictionaryExample();
                    de.P8();
                    break;
                case 9:
                    SortedDictionaryExample sde = new SortedDictionaryExample();
                    sde.P9();
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
        }
    }
}