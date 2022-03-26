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
            _documentTypeRepo = documentTypeRepo ?? throw new NullReferenceException("Falha ao injetar dependencia de documentos");
        }

        public override async Task<IEnumerable<AdminDTO>> FindAll()
        {
            var admins = await _context.GetDbSetByType<Admin>()
                                       .ToListAsync();

            if (admins.Count > 0)
                var (auth, documents) = await ResolveAdminJoins(admins.ToArray());

            return _mapper.Map<List<AdminDTO>>(admins);
        }

        public override async Task<AdminDTO> FindById(long id)
        {
            var admin = await _context.GetDbSetByType<Admin>()
                                      .Where(x => x.Id == id)
                                      .FirstOrDefaultAsync();

            if (admin != null)
                var (auth, documents) = await ResolveAdminJoins(admin);

            return _mapper.Map<AdminDTO>(admin);
        }

        private async Task<(AuthDataDTO auth, IEnumerable<DocumentTypeDTO> documents)> ResolveAdminJoins(params Admin[] admins)
        {
            var auth = await _authDataRepo
                    .FindByFilter(x => admins.ToList()
                                         .Select(l => l.AuthDataId)
                                         .Contains(x.Id));

            var docs = await _documentTypeRepo
                                .FindByFilter(x => admins.ToList()
                                                        .Any(l => l.Documents
                                                        .Contains(x)));

            return (auth.FirstOrDefault() ?? new AuthDataDTO(), docs);
        }
    }
}