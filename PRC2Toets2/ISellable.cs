using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC2Toets2
{
    interface ISellable
    {
        decimal Price { get; set; }
        decimal GetPrice();

    }
}
