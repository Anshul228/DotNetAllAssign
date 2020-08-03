using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Animal
{
    class StringOP
    {
        static void Main()
        {
            Console.WriteLine("enter 1st string");
            string input1 = Console.ReadLine();
            Console.WriteLine("enter 2nd string");
            string input2 = Console.ReadLine();
            
            Console.WriteLine("enter your choice \n1.Concatenate String \n2. Length of Two String\n3.Substring\n4.Replace");
            Console.WriteLine("5.Upper Case\n6.Lower Case\n7.Trim\n8.Split\n9.To Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input);
            //do
            //{
                switch (input)
                {
                    case 1: Console.WriteLine(input1 + input2); break;
                    case 2: Console.WriteLine("Length of 1st String is {0} and length of 2nd string is {1}", input1.Length, input2.Length); break;
                    case 3: Console.WriteLine("{0}  {1}",input1.Substring(2,3),input2.Substring(1,2)); break;
                    case 4:
                    case 5: Console.WriteLine("{0}  {1}", input1.ToUpper(), input2.ToUpper()); break;
                    case 6: Console.WriteLine("{0}  {1}", input1.ToLower(), input2.ToLower()); break;
                    case 7: Console.WriteLine("{0}  {1}",input1.Trim(),input2.Trim()); break;
                    case 8: Console.WriteLine(input1.Split()); break;
                    case 9:return;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            //} while (input!= 9);

            //  Console.WriteLine(input1,input2);
        }
    }
}
