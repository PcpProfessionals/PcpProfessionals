using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("Harddisk",Schema ="COMPONENT")]
    public class HarddiskEntity : BaseComponentEntity
    {
        public long Id { get; set; }

        public string PartNumber { get; set; }

        public int Capacity { get; set; }
        
        [Column("RPM")]
        public string RoundPerMin { get; set; }

        public int Size { get; set; }

        public string Type { get; set; }

        public string Brand { get; set; }
    }
}
