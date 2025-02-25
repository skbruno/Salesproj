using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMVC.Models.Enums
{
    public enum SalesStatus : int
    {
        Pending = 0,
        Billed,
        Canceled
    }
}
