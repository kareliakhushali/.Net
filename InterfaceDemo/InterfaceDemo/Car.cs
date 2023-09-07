using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
  internal class Car : IVehicle
    {
        public void DriveCar()
        {
            Console.WriteLine("Car is being driven");
        }
        #region IVehicle members
        public void Drive()
        {
            Console.WriteLine("Car is being driven");
        }
        #endregion
    }
}
