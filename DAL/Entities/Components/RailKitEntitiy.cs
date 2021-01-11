using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("RailKit", Schema= "COMPONENT")]
    public class RailKitEntitiy : BaseComponentEntity
    {
        public long Id { get; set; }
        public int Size { get; set; }
        public string Model { get; set; }

        public string Brand { get; set; }
    }
}
