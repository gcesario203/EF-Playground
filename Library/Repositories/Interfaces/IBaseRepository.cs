using System.Linq.Expressions;

namespace Library.Repositories.Interfaces
{
    public interface IBaseRepository<T, G>
    {
        Task<IEnumerable<T>> FindAll();
        Task<IEnumerable<T>> FindByFilter(Expression<Func<G, bool>> filter);

        Task<T> FindById(long id);

        Task<T> Create(T vo);
        Task<T> Update(T vo);
        Task<bool> Delete(long id);
    }
}