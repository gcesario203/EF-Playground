using AutoMapper;
using Hdogs.api.Data.DataTransferObject;
using Hdogs.api.Model.Context;
using Hdogs.api.Model.Entity;
using Library.Repositories.Base;

namespace Hdogs.api.Repository
{
    public class DocumentTypeRepository : BaseRepository<DocumentTypeDTO, DocumentType, MySqlContext>
    {
        public DocumentTypeRepository(MySqlContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}