using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("PDU", Schema="COMPONENT")]
    public class PDUEntity
    {
        public long Id { get; set; }
        public int NumberOfPorts { get; set; }

        //Relation
        public BrandEntity Brand { get; set; }
        public long BrandId { get; set; }
    }
}
