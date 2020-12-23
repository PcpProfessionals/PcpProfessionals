using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("RailKit", Schema= "COMPONENT")]
    public class RailKitEntitiy
    {
        public long Id { get; set; }
        public int Size { get; set; }
        public string Model { get; set; }

        //Relation
        public BrandEntity Brand { get; set; }
        public long BrandId { get; set; }
    }
}
