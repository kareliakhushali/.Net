using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
   internal class Scooter:IVehicle
    {
        public void DriveScooter()
        {
            Console.WriteLine("Scooter is being driven");
        }
        public void Drive()
        {
            Console.WriteLine("Scooter is being driven");
        }

    }
}
