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
    public class AdminController : BaseController<AdminRepository, AdminDTO, Admin, MySqlContext>
    {
        private readonly DocumentTypeRepository _documentTypeRepo;
        private readonly AuthDataRepository _authDataRepo;
        public AdminController(AdminRepository repository,
                               DocumentTypeRepository documentTypeRepo,
                               AuthDataRepository authDataRepo) : base(repository)
        {
            _documentTypeRepo = documentTypeRepo;
            _authDataRepo = authDataRepo;
        }
    }
}