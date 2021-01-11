using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("TFTConsole", Schema="COMPONENT")]
    public class TFTConsoleEntity : BaseComponentEntity
    {
        public long Id { get; set; }
        public string Size { get; set; }

        public string Brand { get; set; }
    }
}
