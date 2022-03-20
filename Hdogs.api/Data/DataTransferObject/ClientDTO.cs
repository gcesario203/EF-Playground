using Hdogs.api.Data.Base;

namespace Hdogs.api.Data.DataTransferObject
{
    public class ClientDTO: BasePersonDTO
    {
        public virtual ICollection<long> Pets { get; set; }
        public virtual ICollection<long> Services { get; set; }
    }
}