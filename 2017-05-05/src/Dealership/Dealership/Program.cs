using System;

namespace Dealership
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDemo GetVehicles Stored Proc");

            var service = new VehicleService();
            var list = service.GetVehicles();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}