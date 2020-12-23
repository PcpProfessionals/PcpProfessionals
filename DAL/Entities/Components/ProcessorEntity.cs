using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("Processor", Schema="COMPONENT")]
    public class ProcessorEntity
    {
        public long Id { get; set; }
        public string ModelNumber { get; set; }
        public int CacheSize { get; set; }
        public int NumberOfPorts { get; set; }
        public string Type { get; set; }
        public double Speed { get; set; }
    }
}
