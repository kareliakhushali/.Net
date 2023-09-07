using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryProducts
{
    interface IStationary
    {
        void AddItem(IStationary i);
        void RemoveItem(IStationary i);
        void Fetch();
        
        int CalculateBill();
    }
}
