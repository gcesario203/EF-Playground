using Hdogs.api.Data.Base;

namespace Hdogs.api.Data.DataTransferObject
{
    public class ClientDTO: BasePersonDTO
    {
        public virtual ICollection<PetDTO> Pets { get; set; }
        public virtual ICollection<ServiceDTO> Services { get; set; }
    }
}