using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Laundry laund = new Laundry();
            Customer custom = new Customer();

            int c = custom.giveDirtyClothes(12);

            laund.getDirtyClothes();
            TaxiCab taxi = new TaxiCab();
            Console.Write("Can you take me to the best Laundry place in {0} ", taxi.Location);

            taxi.Move("san");
            laund.getCleanClothes(c);
            custom.receiveCleanClothes("Thanks for getting my clothes laundered");
        }
    }

    class Laundry
    {
        public int Money { get; set; }
        public int DirtyClothes { get; set; }

        public string English { get; set; }
        public void getDirtyClothes()
        {
            Console.Write(" Yes or No ");
            string a = Console.ReadLine();

            if (a.ToLower() == "yes")
            {
                Console.WriteLine("Yes I will get your clothes Laundered ");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public void getCleanClothes(int dirtyclothes)
        {
            this.DirtyClothes = DirtyClothes;
            Console.WriteLine($"{dirtyclothes} Clothes are now clean ");
            Console.WriteLine("Here are your clothes");
        }
    }

    public class TaxiCab
    {

        public string Location;
       
        public void Move(string newLocation)
        {
            this.Location = newLocation;

            if (String.IsNullOrEmpty(this.Location))
            {
                Console.WriteLine("You need to tell me where you are going");
            }
            else
            {
                string b = Console.ReadLine();

            if (b.ToLower() == "yes")
                {
                    Console.WriteLine("Now heading to San Francisco ");
                    
                }
                else
                {
                    Console.WriteLine("No");
                }
            }

        }

    }

    class Customer
    {
        public string English { get; set; }
        public int DirtyClothes { get; set; }
        
        public int giveDirtyClothes(int DirtyClothes)
        {
            Console.WriteLine($"Can you get my {DirtyClothes} clothes laundered please ? ");
            return DirtyClothes;
        }
        public void receiveCleanClothes(string English)
        {
            Console.WriteLine(English);
        }
    }
}


