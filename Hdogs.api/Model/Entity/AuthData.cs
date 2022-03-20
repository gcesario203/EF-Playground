using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Library.Models;

namespace Hdogs.api.Model.Entity
{
    [Table("auth_data")]
    public class AuthData : BaseEntity
    {
        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }
    }
}