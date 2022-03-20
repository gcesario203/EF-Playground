using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hdogs.api.Model.Enum;
using Library.Models;

namespace Hdogs.api.Model.Entity
{
    [Table("pet")]
    public class Pet : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("size")]
        public PetSizeEnum Size { get; set; }

        [Column("type")]
        public PetTypeEnum Type { get; set; }
        public long ClientId { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}