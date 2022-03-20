using Hdogs.api.Data.DataTransferObject;
using Hdogs.api.Model.Context;
using Hdogs.api.Model.Entity;
using Hdogs.api.Repository;
using Library.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace Hdogs.api.Controllers
{
    [Route("/api/[controller]/")]
    [ApiController]
    public class DocumentTypeController : BaseController<DocumentTypeRepository, DocumentTypeDTO, DocumentType, MySqlContext>
    {
        public DocumentTypeController(DocumentTypeRepository repository) : base(repository)
        {

        }
    }
}