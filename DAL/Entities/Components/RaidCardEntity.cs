using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("RaidCard",Schema="COMPONENT")]
    public class RaidCardEntity
    {
        public long Id { get; set; }
        public string Category { get; set; }
        public string Placement { get; set; }

        //Relation 
        public BrandEntity Brand { get; set; }
        public long BrandId { get; set; }
    }
}
