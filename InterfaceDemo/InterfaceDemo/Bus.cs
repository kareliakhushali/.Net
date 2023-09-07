using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Bus:IVehicle
    {
        
        public void Drive()
        {
            Console.WriteLine("Bus is being driven");
        }
        
    }
}
