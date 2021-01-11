using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class BaseComponentEntity : IEntity
    {
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
