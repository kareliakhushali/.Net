using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask
{
    interface IStationary
    {
        int AvailableQuantity { get; set; }
        object Name { get; set; }

        string GetName();
        double GetPrice();
        int GetQuantity();
        int CalculateBill();
    }
}
