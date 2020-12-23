using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("EthernetCard", Schema = "COMPONENT")]
    public class EthernetCardEntity
    {
        public long Id { get; set; }

        public string Type { get; set; }
        public int NumberOfPorts { get; set; }
        public int Speed { get; set; }
        public string SlotType { get; set; }
    }
}
