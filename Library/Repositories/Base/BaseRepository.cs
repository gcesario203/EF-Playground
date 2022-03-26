using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Library.Models;
using Library.Repositories.Interfaces;
using Library.Contexts;
using System.Linq.Expressions;

namespace Library.Repositories.Base
{
    /// <summary>
    ///  Classe base dos repositórios
    /// </summary>
    public abstract class BaseRepository<T, G, V> : IBaseRepository<T, G>
    where G : BaseEntity
    where V : BaseDBContext<V>
    {
        protected readonly V _context;
        protected IMapper _mapper;

        public BaseRepository(V context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual async Task<IEnumerable<T>> FindAll()
        {
            var items = await _context.GetDbSetByType<G>().ToListAsync();
            return _mapper.Map<List<T>>(items);
        }

        public virtual async Task<T> FindById(long id)
        {
            return _mapper.Map<T>(await _context.GetDbSetByType<G>().Where(x => x.Id == id).FirstOrDefaultAsync());
        }
        public virtual async Task<T> Create(T vo)
        {
            var item = _mapper.Map<G>(vo);

            _context.GetDbSetByType<G>().Add(item);

            await _context.SaveChangesAsync();

            return vo;
        }

        public virtual async Task<T> Update(T vo)
        {
            var item = _mapper.Map<G>(vo);

            _context.GetDbSetByType<G>().Update(item);

            await _context.SaveChangesAsync();

            return vo;
        }

        public virtual async Task<bool> Delete(long id)
        {
            try
            {
                var item = await _context.GetDbSetByType<G>().Where(x => x.Id == id).FirstOrDefaultAsync();


                if (item == null) return false;

                _context.GetDbSetByType<G>().Remove(item);

                await _context.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<T>> FindByFilter(Expression<Func<G, bool>> filter)
        {
            var items = await _context.GetDbSetByType<G>().ToListAsync();
            return _mapper.Map<List<T>>(items);
        }
    }
}