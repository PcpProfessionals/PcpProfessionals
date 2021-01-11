using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("RiserCard", Schema="COMPONENT")]
    public class RiserCardEntity : BaseComponentEntity
    {
        public long Id { get; set; }
        public string Category { get; set; }
        public string Placement { get; set; }
    }
}
