using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("SFP", Schema="COMPONENT")]
    public class SFPEntity
    {
        public long Id { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
    }
}
