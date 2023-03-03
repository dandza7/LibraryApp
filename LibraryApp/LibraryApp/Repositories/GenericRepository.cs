using LibraryApp.Models;
using LibraryApp.Models.DTO;
using LibraryApp.Models.DTO.PFS;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace LibraryApp.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        private readonly DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<T> Create(T entity)
        {
            DateTime now = DateTime.UtcNow;
            entity.CreatedDate = now;
            entity.ModifiedDate = now;
            await _dbContext.Set<T>().AddAsync(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            entity.ModifiedDate = DateTime.UtcNow;
            entity.IsDeleted = true;
            _dbContext.Set<T>().Update(entity);
        }

        public async Task<T?> GetById(long id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> entities = _dbContext.Set<T>();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    entities = entities.Include(include);
                }
            }
            return await entities
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> entities = _dbContext.Set<T>();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    entities = entities.Include(include);
                }
            }
            return entities;
        }

        public PaginationResponseWrapper<T> Filter(PaginationQueryDTO? paginationQueryDTO, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> entities = _dbContext.Set<T>();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    entities = entities.Include(include);
                }
            }
            if (paginationQueryDTO == null)
            {
                var list = entities.ToList();
                return new PaginationResponseWrapper<T>(list, list.Count);
            }
            if (!paginationQueryDTO.Filters.IsNullOrEmpty())
            {
                foreach (var filter in paginationQueryDTO.Filters)
                {
                    entities = entities.Where(filter.ToString());
                }
            }
            if (!paginationQueryDTO.Order.IsNullOrEmpty())
            {
                List<string> orderList = paginationQueryDTO.Order.Select(o => o.OrderField + " " + o.Ordering).ToList();
                string orderQuery = String.Join(",", orderList);
                entities = entities.OrderBy(orderQuery);

            }
            var totalCount = entities.Count();
            if (paginationQueryDTO.Page > 0 && paginationQueryDTO.PageSize > 0)
            {
                entities = entities.Skip((paginationQueryDTO.Page - 1) * paginationQueryDTO.PageSize).Take(paginationQueryDTO.PageSize);
            }
            return new PaginationResponseWrapper<T>(entities.ToList(), totalCount);
        }

        public T Update(T entity)
        {
            entity.ModifiedDate = DateTime.UtcNow;
            _dbContext.Set<T>().Update(entity);
            return entity;
        }
    }
}
