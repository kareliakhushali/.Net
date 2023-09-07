using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask1
{
    interface IStationary
    {
       void AddItem();
        void RemoveItem();
        void Fetch();
        int DiscountTotal();
        int CalculateBill();
    }
}
