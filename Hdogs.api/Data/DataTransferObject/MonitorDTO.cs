using Hdogs.api.Data.Base;

namespace Hdogs.api.Data.DataTransferObject
{
    public class MonitorDTO : BasePersonDTO
    {
        public long Admin { get; set; }
        public virtual ICollection<long> Services { get; set; }
    }
}