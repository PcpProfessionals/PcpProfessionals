using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("TFTConsole", Schema="COMPONENT")]
    public class TFTConsoleEntity
    {
        public long Id { get; set; }
        public string Size { get; set; }

        //Relation
        public BrandEntity Brand { get; set; }
        public long BrandId { get; set; }
    }
}
