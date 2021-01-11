using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("RaidBattery", Schema="COMPONENT")]
    public class RaidBatteryEntity : BaseComponentEntity
    {
        public long Id { get; set; }
        public string Type { get; set; }
    }
}
