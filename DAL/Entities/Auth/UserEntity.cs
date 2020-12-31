using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Auth
{
    [Table("User", Schema = "AUTH")]
    public class UserEntity
    {
        public long Id { get; set; }
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime ExpiryOn { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}
