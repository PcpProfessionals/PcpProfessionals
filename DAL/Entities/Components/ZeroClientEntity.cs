using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("ZeroClient", Schema="COMPONENT")]
    public class ZeroClientEntity : BaseComponentEntity
    {

        public long Id { get; set; }
        public string Model { get; set; }

        public string Brand { get; set; }
    }
}
