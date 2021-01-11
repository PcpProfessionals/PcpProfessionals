using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("ThinClient", Schema = "COMPONENT")]
    public class ThinClientEntity : BaseComponentEntity
    {
        public long Id { get; set; }
        public string Model { get; set; }
        public string Ram { get; set; }
        public string Processor { get; set; }
        public string HardDisk { get; set; }

        public string Brand { get; set; }
    }
}
