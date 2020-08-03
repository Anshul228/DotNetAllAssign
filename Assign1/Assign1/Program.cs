using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    abstract class Quadrilateral
    {
        public static int length;
        public abstract int area();
        public Quadrilateral(int _length)
        {
        }
    }
    class Square : Quadrilateral
    {
        
        public override int area()
        {
            return length*length;
        }
        public Square(int length):base(length)
        {
             Quadrilateral.length= length;
        }
    }
    class Rectangle : Quadrilateral
    {
        
        public int Breadth;
        public Rectangle(int _length,int _breadth):base(_length)
        {
            Breadth = _breadth;
            Quadrilateral.length = _length;
        }
        public override int area()
        {
            return length*Breadth;
        }
        public bool IsSquare {
            get { return IsSquare; }
            set { IsSquare = value; } 
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            bool flag=false;
            Square sq = new Square(4);
            Rectangle rect = new Rectangle(5,6);
            //a =(int) sq.area();
            Console.WriteLine("Area of Square is :{0}",sq.area());
            Console.WriteLine("Area of Reactangle is :{0}",rect.area());
            if (sq.area()>rect.area())
             Console.WriteLine("Area of Square is greater than Rectangle");
             
            else Console.WriteLine("Area of Rectangle is greater than Square");
            int s, r;
            s = sq.area();
            r = rect.area();
            Console.WriteLine(Convert.ToString(s));
            Console.WriteLine(Convert.ToString(r));
            //if (sq.area()==rect.area())
            //{
            //    flag = true;
            //}
            //Console.WriteLine(flag);
            //rect.IsSquare = flag;
        }
    }
}
