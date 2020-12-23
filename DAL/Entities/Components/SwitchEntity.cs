using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("Switch", Schema="COMPONENT")]
    public class SwitchEntity
    {
        public long Id { get; set; }
        public string Brand { get; set; }
        public int NumberOfPorts { get; set; }
        public string ModelNumber { get; set; }
    }
}
