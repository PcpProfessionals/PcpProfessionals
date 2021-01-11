using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("Storage", Schema = "COMPONENT")]
    public class StorageEntity : BaseComponentEntity
    {
        public long Id { get; set; }
        public string Controller { get; set; }

        public string Brand { get; set; }
    }
}
