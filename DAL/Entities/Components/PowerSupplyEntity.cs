using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("PowerSupply", Schema="COMPONENT")]
    public class PowerSupplyEntity : BaseComponentEntity
    {
        public long Id { get; set; }
        public string ModelNumber { get; set; }
        public string Watt { get; set; }
        public int NumberOfPorts { get; set; }

        public string Brand { get; set; }
    }
}
