using Hdogs.api.Data.Base;

namespace Hdogs.api.Data.DataTransferObject
{
    public class MonitorDTO : BasePersonDTO
    {
        public AdminDTO Admin { get; set; }
        public virtual ICollection<ServiceDTO> Services { get; set; }
    }
}