using Hdogs.api.Data.Base;
using Hdogs.api.Model.Enum;

namespace Hdogs.api.Data.DataTransferObject
{
    public class DocumentTypeDTO : BaseDTO
    {
        public string Value { get; set; }
        public DocumentTypeEnum Type { get; set; }
    }
}