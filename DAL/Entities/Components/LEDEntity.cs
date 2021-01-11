using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("LED", Schema="COMPONENT")]
    public class LEDEntity : BaseComponentEntity
    {
        public long Id { get; set; }

        public int Size { get; set; }

        public string Brand { get; set; }
    }
}
