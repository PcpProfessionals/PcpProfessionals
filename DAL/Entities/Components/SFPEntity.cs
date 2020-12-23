using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("SFP", Schema="COMPONENT")]
    public class SFPEntity
    {
        public string Model { get; set; }
        public int Speed { get; set; }
    }
}
