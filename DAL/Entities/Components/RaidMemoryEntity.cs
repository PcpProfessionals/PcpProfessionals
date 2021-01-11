using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("RaidMemory", Schema="COMPONENT")]
    public class RaidMemoryEntity : BaseComponentEntity
    {
        public long Id { get; set; }
        public int Size { get; set; }

        public string Brand { get; set; }
    }
}
 