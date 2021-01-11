using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("Memory",Schema="COMPONENT")]
    public class MemoryEntity : BaseComponentEntity
    {
        public long Id { get; set; }
        public int Size { get; set; }
        public string Rank { get; set; }
        public int Ddr { get; set; }
        public bool HeatSink { get; set; }

        public string Brand { get; set; }
    }
}
