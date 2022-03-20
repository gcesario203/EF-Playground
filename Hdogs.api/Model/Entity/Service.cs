using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hdogs.api.Model.Enum;
using Library.Models;

namespace Hdogs.api.Model.Entity
{
    [Table("service")]
    public class Service : BaseEntity
    {

        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }


        [Column("description")]
        [StringLength(500)]
        public string Description { get; set; }


        [Column("status")]
        [Required]
        public ServiceStatusEnum Status { get; set; }

        [Column("price")]
        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }

        public long MonitorId { get; set; }

        [ForeignKey("MonitorId")]
        public Monitor Monitor { get; set; }

        public long ClientId { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }
      
        public long PetId { get; set; }

        [ForeignKey("PetId")]
        public Pet Pet { get; set; }
    }
}