using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("SAASCable", Schema = "COMPONENT")]
    public class SAASCableEntity : BaseComponentEntity
    {
        public long Id { get; set; }
        public double Size { get; set; }

        public string Brand { get; set; }
    }
}
