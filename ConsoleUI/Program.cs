using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle -- Done
             * The vehicle class shall have three string properties Year, Make, and Model -- Done
             * Set the defaults to something generic in the Vehicle class -- Done
             * Vehicle shall have an abstract method called DriveAbstract with no implementation -- Done
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. -- Done
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle -- Done
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle -- Done
             * Provide the implementations for the abstract methods -- Done
             * Only in the Motorcycle class will you override the virtual drive method -- Done
            */

            // Create a list of Vehicle called vehicles -- Done
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes -- Done

             * Set the properties with object initializer syntax -- Done
             */
            Car Corolla = new Car() { HasTrunk = true, Make = "Toyota", Model = "Corolla", Year = 2012};
            Motorcycle Harley = new Motorcycle() { HasSideCart = true, Make = "Harley Davidson", Model = "BigBoy", Year = 1999 };
            Vehicle Sedan = new Car() { HasTrunk = true, Make = "Dodge", Model = "Bloop", Year = 1894 };
            Vehicle SportCar = new Car() { Make = "Ford", Model = "Mustang", Year = 2022 }; 

            /*
             * Add the 4 vehicles to the list -- Done 
             * Using a foreach loop iterate over each of the properties -- Done
             */
            vehicles.Add(Corolla);
            vehicles.Add(Harley);
            vehicles.Add(Sedan);
            vehicles.Add(SportCar);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make} Model: {vehicle.Model} Year: {vehicle.Year}.");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine($"--------");
            }

            // Call each of the drive methods for one car and one motorcycle


            #endregion            
            Console.ReadLine();
        }
    }
}
