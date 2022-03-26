using AutoMapper;
using Hdogs.api.Data.DataTransferObject;
using Hdogs.api.Model.Context;
using Hdogs.api.Model.Entity;
using Library.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Hdogs.api.Repository
{
    public class AdminRepository : BaseRepository<AdminDTO, Admin, MySqlContext>
    {
        private readonly AuthDataRepository _authDataRepo;
        private readonly DocumentTypeRepository _documentTypeRepo;
        public AdminRepository(MySqlContext context,
                               IMapper mapper,
                               AuthDataRepository authDataRepo,
                               DocumentTypeRepository documentTypeRepo)
                               : base(context, mapper)
        {
            _authDataRepo = authDataRepo ?? throw new NullReferenceException("Falha ao injetar dependencia de autorização");
            _documentTypeRepo = documentTypeRepo ?? throw new NullReferenceException("Falha ao injetar dependencia de autorização");
        }

        public override async Task<IEnumerable<AdminDTO>> FindAll()
        {
            var auth = await _authDataRepo.FindAll();
            var docs = await _documentTypeRepo.FindAll();

            var admins = await _context.Admins
                                       .ToListAsync();
                                                                              ;

            return _mapper.Map<List<AdminDTO>>(admins);
        }
    }
}