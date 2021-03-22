using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformer_Application
{

    //Develop a Transformer Application
    public enum Landscape
    {
        //this will increment automatically from 0 to 2
        air, 
        road, 
        water,
    }

    //Parent Class
    class Transformer
    {
        //hiding values from public
        public int wheels {get; set;}
        public int maxSpeed {get; set;}

        public virtual void Run()
        {
            
        }
    }

    class Jet : Transformer
    {
        int wheels = 8;
        int maxSpeed = 900;
        public override void Run()
        {
            Console.WriteLine("Transformer is on air");
            Console.WriteLine();
            Console.WriteLine($"Wheels = {wheels}\nMax Speed = {maxSpeed}");
        }
        
    }

    class Car : Transformer
    {
        int wheels = 4;
        int maxSpeed = 350;
        public override void Run()
        {
            Console.WriteLine("Transformer is on road");
            Console.WriteLine();
            Console.WriteLine($"Wheels = {wheels}\nMax Speed = {maxSpeed}");
        }
    }

    class Boat : Transformer
    {
        int wheels = 0;
        int maxSpeed = 200;
        public override void Run()
        {
            Console.WriteLine("Transformer is on water");
            Console.WriteLine();
            Console.WriteLine($"Wheels = {wheels}\nMax Speed = {maxSpeed}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Transformer t = new Transformer();
                t.Run();

                Console.WriteLine("Enter\n(0) for Air\n(1) for Road\n(2) for water ");
                Console.WriteLine();
                Console.Write("Enter Value from 0 to 2 : ");

                Landscape move = (Landscape)int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (move)
                {
                    case Landscape.air:
                        Jet j = new Jet();
                        j.Run();
                        break;
                    case Landscape.road:
                        Car c = new Car();
                        c.Run();
                        break;
                    case Landscape.water:
                        Boat b = new Boat();
                        b.Run();
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                } Console.WriteLine("Press X to exit or any Key to Continue..");
                
            } while (Console.ReadLine().ToUpper() != "X");
        }
    }
}
