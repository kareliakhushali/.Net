using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
   internal class Driver03
    {
        public void Driveobject(IVehicle objVehicle)
        {
            Console.WriteLine("Driver is now driving a vehicle :{0}",   
               objVehicle.GetType().Name);
            objVehicle.Drive();

        }
        
    }
}
