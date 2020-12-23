using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("SAASCable", Schema="COMPONENT")]
    public class SAASCableEntity
    {
        public long Id { get; set; }
        public double Size { get; set; }

        //Relation
        public BrandEntity Brand { get; set; }
        public long BrandId { get; set; }
    }
}
