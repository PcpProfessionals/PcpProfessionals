using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("RaidMemory", Schema="COMPONENT")]
    public class RaidMemoryEntity
    {
        public long Id { get; set; }
        public int Size { get; set; }

        //Relation
        public BrandEntity Brand { get; set; }
        public long BrandId { get; set; }
    }
}
 