using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();

            Console.WriteLine("Welcome to the car store. First you must create some car inventory.");

            int action = chooseAction();

            while (action != 0)
            {
                Console.WriteLine("You choose " + action);

                switch(action)
                {
                    case 1:
                        Console.WriteLine("You choose to add a new car to the inventory.");

                        String carMake = "";
                        String carModel = "";
                        Decimal carPrice = 0;

                        Console.WriteLine("What is the car make? Ford, nissan, bmw, etc.");
                        carMake = Console.ReadLine();

                        Console.WriteLine("What is the car model? Corvette, focus, astra, etc.");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the car price?");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar = new Car(carMake, carModel, carPrice);
                        s.CarList.Add(newCar);

                        printInventory(s);
                        break;
                }

                action = chooseAction();
            }

            /*
            Car c = new Car("Nissan", "Sentra", 40000);
            Car d = new Car("Opel", "Astra", 30000);

            Console.WriteLine("Car c is as follows " + c.Make + " " + c.Model + " " + c.Price);
            Console.WriteLine("Car d is as follows " + d.Make + " " + d.Model + " " + d.Price);

            Store s = new Store();

            s.ShoppingList.Add(c);
            s.ShoppingList.Add(d);

            decimal total = s.Checkout();

            Console.WriteLine("Store value is " + total);
            */
        }

        private static void printInventory(Store s)
        {
            foreach(Car c in s.CarList)
            {
                Console.WriteLine("Car: " + c.Make + " " + c.Model + " " + c.Price);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new car to inventory (2) to add car to cart (4) to checkout!");
            
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}