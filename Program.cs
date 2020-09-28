using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        // A (private) field, k, is a property private in nature, but available to all members of the class.
        private static string k = "";

        static void Main(string[] args)
        {
            //UNDERSTANDING SCOPE

            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                Console.WriteLine(l);
            }
            Console.WriteLine("Outside of the for loop: " + j);
            HelperMethod();

            //OBJECT LIFETIME
            /*
            Car myCar = new Car();

            Car.MyMethod();
            /*
            myCar.Make = "Oldsmoblile";
            myCar.Model = "Cuslass Supre";
            myCar.Year = 1996;
            myCar.Color = "Silver";


            Car myOtherCar;
            myOtherCar = myCar;

            Car myThirdCar = new Car("Ford", "Escape", 2005, "Blue");


            // This shows that when you have two references to the same space in memory, you can change it
            // or call the value with any of the two
            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            // Setting the objects to null remove the references to the storage in memory and the .NET runtime 
            // handles removing the items and binning them, a process called garbage collection. 
            // Because this process can sometimes create a problem before the binning is performed, there is a
            // solution called "deterministic finalization."

            /*
            myOtherCar = null;
            myCar = null;
            */

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("This is the helper method: calling k" + k);
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            // To load from a ...(e.g., a configuration file, a database, etc.) into the object
            this.Make = "Nissan"; // Note that the "this." is not necessary
        }
         // It is possible to overload the class the same way it possible with methods
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
        }
    }
}
