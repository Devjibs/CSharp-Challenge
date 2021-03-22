using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesinC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Working with classes
            Console.WriteLine(Person.name);

        }
    }

    //Working with classes
    class Person
    {
        string name = "Habeeb";
        byte age = 26;

        static void canEat(bool true)
        {
            Console.WriteLine($"{Person.name} can eat");
        }
    }
}
