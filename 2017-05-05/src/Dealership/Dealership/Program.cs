using System;

namespace Dealership
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new VehicleService();
            var list = service.GetVehicles();
            foreach (var item in list)
            {
                // do stuff
            }
        }
    }
}