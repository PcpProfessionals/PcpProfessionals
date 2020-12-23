using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("HeatSink", Schema= "COMPONENT")]
    public class HeatSinkEntity
    {
        public long Id { get; set; }
        public string ServerModel { get; set; }
    }
}
