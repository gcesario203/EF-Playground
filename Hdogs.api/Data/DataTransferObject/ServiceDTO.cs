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

        public PetDTO Pet { get; set; }
        public ClientDTO Client { get; set; }
        public MonitorDTO Monitor { get; set; }
    }
}