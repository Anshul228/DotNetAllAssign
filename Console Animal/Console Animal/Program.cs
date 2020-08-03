using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string[] MyArray = { "Zebra", "Ant", "Owl", "Lion" };
            for (i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]+"    ");

            }
            foreach (var item in MyArray)
            {
                Console.WriteLine(item);

            }
            i = 0;
            while (i<MyArray.Length)
            {
                Console.WriteLine(MyArray[i] +"while");
                i++;
            }

            i = 0;
            do
            {
                Console.WriteLine(MyArray[i]);
                i++;
            } while (i<MyArray.Length);
            Array.Sort(MyArray);
            Console.WriteLine("#################\n Sort\n");
            foreach (var item in MyArray)
            {
                Console.WriteLine(item);
            }
            string[] animals = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            string[] places = { "Africa", "New Zealand", "Jamaica", "India" };
            Array.Sort(animals);
            Console.WriteLine("Sorted animals \n");
            foreach (var item in animals)
            {
                Console.WriteLine(item);

            }
            Array.Sort(places);
            Console.WriteLine("Sorted places \n");
            foreach (var item in places)
            {
                Console.WriteLine(item);

            }
        }
    }
}
