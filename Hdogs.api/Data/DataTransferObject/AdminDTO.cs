using Hdogs.api.Data.Base;

namespace Hdogs.api.Data.DataTransferObject
{
    public class AdminDTO : BasePersonDTO
    {
        public virtual ICollection<long> Monitors { get; set; }
    }
}