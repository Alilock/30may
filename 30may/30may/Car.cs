using System;
using System.Collections.Generic;
using System.Text;

namespace _30may
{
    internal class Car
    {

        

        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Millage;


        public Car(string brand, string model, double currentFuel, double fuelForKm, double millage)
        {

            Brand = brand;
            Model = model;
            CurrentFuel = currentFuel;
            FuelFor1Km = fuelForKm;
            Millage = millage;


        }
    public void drive()
        {
            Console.Write("Gedeceyiniz mesafeni qeyd edin: ");
           int distance = int.Parse(Console.ReadLine());
            if (distance * FuelFor1Km <= CurrentFuel)
            {
                Console.WriteLine("Kifayet qeder yanacaq var!");
                Millage += distance;
                CurrentFuel -= distance * FuelFor1Km;
                Console.WriteLine($"Gedisden sonraki kilometrajiniz : {Millage} km");
                Console.WriteLine($"Gedisden sonraki qalacaq yanacaginiz: {CurrentFuel} litr");




            }
            else
            {

                double NeedFuel = distance * FuelFor1Km - CurrentFuel;
                Console.WriteLine(" Kifayet qeder yanacaq yoxdur!  ");
                Console.WriteLine($"Size lazim olan elave yanacaq miqdari {NeedFuel} litr ");



            }

        }


    }
}
