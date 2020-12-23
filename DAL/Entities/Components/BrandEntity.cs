using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("Brand",Schema = "COMPONENT")]
    public class BrandEntity
    {
        public long Id { get; set; }

        public string Name { get; set; }
    }
}
