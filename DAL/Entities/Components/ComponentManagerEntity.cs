using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Components
{
    [Table("Manager", Schema= "COMPONENT")]
    public class ComponentManagerEntity : BaseComponentEntity
    {
        public long Id { get; set; }

        public string ComponentName { get; set; }

    }
}
