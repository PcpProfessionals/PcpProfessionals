using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("KVM", Schema="COMPONENT")]
    public class KVMEntity
    {
        public long Id { get; set; }

        public string Type { get; set; }
        public int NumberOfPorts { get; set; }


        //Relation
        public BrandEntity Brand { get; set; }
        public long BrandId { get; set; }
    }
}
