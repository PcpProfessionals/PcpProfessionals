using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("Storage", Schema="COMPONENT")]
    public class StorageEntity
    {
        public long Id { get; set; }
        public string Controller { get; set; }

        //Relation
        public BrandEntity Brand { get; set; }
        public long BrandId { get; set; }
    }
}
