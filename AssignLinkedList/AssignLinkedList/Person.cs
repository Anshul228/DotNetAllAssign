using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignLinkedList
{
    class Person
    {
        int age;
        string fname, lname, city;


        public Person()
        {

        }
        public Person(int Age,string Fname,string Lname,string City)
        {
            age = Age;
            fname = Fname;
            lname = Lname;
            city = City;
        }
        void DisplayPerson()
        {
            Console.WriteLine("Full Name is {0} {1} \n Age is {2}\n City is {3}",fname ,lname ,age ,city );
        }
        static void Main()
        {
            List<Person> lp = new List<Person>();
            Person p1 = new Person(21, "Anshul", "Haldkar", "Jabalpur");
            Person p2 = new Person(25, "Siddharth", "Baliyan", "Meerut");
            Person p3 = new Person(50,"Anushree","Agrawal","Mirzapur");
            Person p4 = new Person(30, "Sumit", "Nema", "Bhopal");
            Person p5 = new Person(55, "Ashok", "Verma", "Indore");
            lp.Add(p1);
            lp.Add(p2);
            lp.Add(p3);
            lp.Add(p4);
            lp.Add(p5);
            foreach (var item in lp  )
            {
                item.DisplayPerson();
            }

        }
    }
}
