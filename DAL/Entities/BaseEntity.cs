using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class BaseComponentEntity 
    {
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double SellingPrice { get; set; }
        public double AveragePrice { get; set; }
        public double PurchasingPrice { get; set; }
    }
}
