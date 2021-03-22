using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Temperature_Converter_Application
{
    class Program
    {
        static void Main(string[] args)
        {

            //Develop Temperature Converter Application

            //Farenheite to Celcius
            FahrenhiteTemprature fahr = new FahrenhiteTemprature();
            Console.Write("Enter number of fahrenhite to convert to celcius : ");
            fahr.Fahrenhite = float.Parse(Console.ReadLine());

            //Celcius to Farenheite
            CelciusTemprature celc = fahr;
            Console.WriteLine($"°{celc.Celcius}");
        }
    }

    class FahrenhiteTemprature
    {
        public float Fahrenhite;

        //Method for converting Farenheite to Celcius

        public static implicit operator CelciusTemprature(FahrenhiteTemprature ftemp)
        {
            CelciusTemprature celc = new CelciusTemprature();
            celc.Celcius = (ftemp.Fahrenhite - 32) * 5 / 9;

            return celc;
        }

    }

    class CelciusTemprature
    {
        public float Celcius { get; set; }

        //Method for converting Celcius to Farenheite

        public static implicit operator FahrenhiteTemprature(CelciusTemprature ctemp)
        {
            FahrenhiteTemprature fahr = new FahrenhiteTemprature();
            fahr.Fahrenhite = (ctemp.Celcius * 9 / 5) + 32;

            return fahr;
        }
    }
}

