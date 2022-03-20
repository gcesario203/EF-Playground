using Hdogs.api.Data.DataTransferObject;

namespace Hdogs.api.Data.Base
{
    public class BasePersonDTO : BaseDTO
    {
        public AuthDataDTO AuthData { get; set; }
        public string Name { get; set; }
        public ICollection<DocumentTypeDTO> Documents { get; set; }
    }
}