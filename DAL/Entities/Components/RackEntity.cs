using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("Rack", Schema="COMPONENT")]
    public class RackEntity : BaseComponentEntity
    {
        public long Id { get; set; }
        public string Size { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
    }
}
