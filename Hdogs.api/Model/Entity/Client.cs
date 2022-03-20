using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Library.Models;

namespace Hdogs.api.Model.Entity
{
    [Table("client")]
    public class Client : BaseEntity
    {
        public long AuthDataId { get; set; }

        [ForeignKey("AuthDataId")]
        public AuthData AuthData { get; set; }

        [Required]
        [StringLength(150)]
        [Column("name")]
        public string Name { get; set; }

        public virtual ICollection<DocumentType> Documents { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}