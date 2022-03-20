using Hdogs.api.Data.Base;
using Hdogs.api.Model.Enum;

namespace Hdogs.api.Data.DataTransferObject
{
    public class ServiceDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ServiceStatusEnum Status { get; set; }
        public decimal Price { get; set; }

        public long Pet { get; set; }
        public long Client { get; set; }
        public long Monitor { get; set; }
    }
}