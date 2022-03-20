using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hdogs.api.Model.Enum;
using Library.Models;

namespace Hdogs.api.Model.Entity
{
    [Table("document")]
    public class DocumentType : BaseEntity
    {
        [Column("value")]
        [Required]
        public string Value { get; set; }

        [Column("type")]
        [Required]
        public DocumentTypeEnum Type { get; set; }
    }
}