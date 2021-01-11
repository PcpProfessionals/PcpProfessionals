using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("RaidCard",Schema="COMPONENT")]
    public class RaidCardEntity : BaseComponentEntity
    {
        public long Id { get; set; }
        public string Category { get; set; }
        public string Placement { get; set; }

        public string Brand { get; set; }
    }
}
