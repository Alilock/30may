using System;

namespace _30may
{
    internal class Program
    {
        static void Main(string[] args)
          {
            Notebook[] notebooks = new Notebook[4];
            notebooks[0] = new Notebook()
            {
                Name = "Lenovo",
                BrandName = "Yoga S6",
                Price = 1400
            };

            notebooks[1] = new Notebook()
            {
                Name = "Acer",
                BrandName = "Aspire",
                Price = 1720

            };

            notebooks[2] = new Notebook()
            {
                Name = "Apple",
                BrandName = "MacBook Pro",
                Price = 4000
            }; notebooks[3] = new Notebook()
            {
                Name = "Hp",
                BrandName = "Pavilion",
                Price = 900
            };

            Console.WriteLine("Minimum qiymeti yazin");

            int minPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Maximum qiymeti yazin");
            int maxPrice = int.Parse(Console.ReadLine());






            for (int i = 0; i < notebooks.Length; i++)
            {
                if (notebooks[i].Price > minPrice && notebooks[i].Price < maxPrice)
                {
                    Console.WriteLine($"{notebooks[i].Name} {notebooks[i].BrandName} , {notebooks[i].Price}");
                }
                else
                {
                    Console.WriteLine("Axtarsiginiz qiymet araliginda notebook yoxdur!");
                    break;
                }
            }

            Console.WriteLine("==================================================");


            Car car = new Car("Ford", "Fusion", 50, 0.5, 195000);
            Car car1 = new Car("Mersedec", "W124", 75, 0.5, 314670);

            Console.Write($"Masinlardan birini sec: ");
            Console.WriteLine($" 1.{car.Brand}, 2.{car1.Brand}");
            bool check = false;
            while (true)
            {


                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    car.drive();
                     
                    break; 
                }
                else if (a == 2)
                {
                    car1.drive();
                    break;
                }
                else
                {
                    Console.WriteLine("Duzgun reqem daxil et!");
                    check = false;
                }

            }


            

            

            

           


        }
    }
}
