using AutoMapper;
using Hdogs.api.Data.DataTransferObject;
using Hdogs.api.Model.Entity;

namespace Hdogs.api.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<AuthDataDTO, AuthData>().ReverseMap();
                config.CreateMap<DocumentTypeDTO, DocumentType>().ReverseMap();
                config.CreateMap<AdminDTO, Admin>().ReverseMap();
                config.CreateMap<MonitorDTO, Hdogs.api.Model.Entity.Monitor>().ReverseMap();
                config.CreateMap<PetDTO, Pet>().ReverseMap();
                config.CreateMap<ServiceDTO, Service>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}