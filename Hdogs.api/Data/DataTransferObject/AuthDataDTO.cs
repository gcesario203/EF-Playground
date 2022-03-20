using Hdogs.api.Data.Base;

namespace Hdogs.api.Data.DataTransferObject
{
    public class AuthDataDTO : BaseDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}