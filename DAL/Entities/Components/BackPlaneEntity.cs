using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("BackPlane", Schema="COMPONENT")]
    public class BackPlaneEntity
    {
        public long Id { get; set; }

        public string Type { get; set; }

        public int Size { get; set; }

        public int NumberOfPorts { get; set; }
    }
}
