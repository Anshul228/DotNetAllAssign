using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample;

namespace Assign3
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle("Cielo","red", 4, 1, 2);
            v.start();
            v.stop();
            v.Display();

        }
    }
}
