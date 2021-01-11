using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("PDU", Schema="COMPONENT")]
    public class PDUEntity : BaseComponentEntity
    {
        public long Id { get; set; }
        public int NumberOfPorts { get; set; }

        public string Brand { get; set; }
    }
}
