using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("ZeroClient", Schema="COMPONENT")]
    public class ZeroClientEntity
    {

        public long Id { get; set; }
        public string Model { get; set; }

        //Relation
        public BrandEntity Brand { get; set; }
        public long BrandId { get; set; }
    }
}
