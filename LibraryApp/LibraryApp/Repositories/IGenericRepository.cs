using LibraryApp.Models;
using LibraryApp.Models.DTO;
using LibraryApp.Models.DTO.PFS;
using System.Linq.Expressions;

namespace LibraryApp.Repositories
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes);
        public PaginationResponseWrapper<T> Filter(PaginationQueryDTO? paginationQueryDTO, params Expression<Func<T, object>>[] includes);
        public Task<T?> GetById(long id, params Expression<Func<T, object>>[] includes);
        public Task<T> Create(T entity);
        public T Update(T entity);
        public void Delete(T entity);
    }
}
