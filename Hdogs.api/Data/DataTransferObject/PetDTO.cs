using Hdogs.api.Data.Base;
using Hdogs.api.Model.Enum;

namespace Hdogs.api.Data.DataTransferObject
{
    public class PetDTO : BaseDTO
    {
        public string Name { get; set; }
        public PetSizeEnum Size { get; set; }
        public PetTypeEnum Type { get; set; }
        public long Client { get; set; }
        public virtual ICollection<long> Services { get; set; }
    }
}