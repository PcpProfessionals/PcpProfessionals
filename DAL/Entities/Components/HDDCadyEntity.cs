using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("HddCady", Schema="COMPONENT")]
    public class HDDCadyEntity : BaseComponentEntity
    {
        public long Id { get; set; }
        public double Size { get; set; }

        public string Brand { get; set; }
    }
}
