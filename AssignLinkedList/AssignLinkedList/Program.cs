using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<string> ls = new LinkedList<string>(new string[] {"quick","fox","the","lazy" });
            Console.WriteLine("------------Add First-----------");
            ls.AddFirst("the");
            foreach (var item in ls)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("------------Add Last--------------");
            ls.AddLast("dog");
            foreach (var item in ls)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
           // the quick fox the lazy dog
            Console.WriteLine("-----------Add After-------------");
            ls.AddAfter(ls.Find("quick"), "brown");
            foreach (var item in ls)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
           // the quick brown fox the lazy dog
            Console.WriteLine("------------Add Before-----------");
            ls.AddBefore(ls.FindLast("the"), "jump over");
            foreach (var item in ls)
            {
                Console.Write(item + " ");
            }
        }
    }
}
