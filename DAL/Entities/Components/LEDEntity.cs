using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("LED", Schema="COMPONENT")]
    public class LEDEntity
    {
        public long Id { get; set; }

        public int Size { get; set; }

        //Relation
        public BrandEntity Brand { get; set; }
        public long BrandId { get; set; }
    }
}
