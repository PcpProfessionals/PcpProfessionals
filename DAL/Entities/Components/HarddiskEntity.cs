using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("Harddisk",Schema ="COMPONENT")]
    public class HarddiskEntity
    {
        public long Id { get; set; }

        public string PartNumber { get; set; }

        public int Capacity { get; set; }
        
        [Column("RPM")]
        public string RoundPerMin { get; set; }

        public int Size { get; set; }

        public string Type { get; set; }

        //Relations
        public BrandEntity Brand { get; set; }
        public long BrandId { get; set; }
    }
}
