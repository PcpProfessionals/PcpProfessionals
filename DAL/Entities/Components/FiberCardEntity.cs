using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("FiberCard", Schema="COMPONENT")]
    public class FiberCardEntity
    {
        public long Id { get; set; }
        public string ModelNumber { get; set; }
        public string TransferRate { get; set; }
        public int NumberOfPorts { get; set; }
    }
}
