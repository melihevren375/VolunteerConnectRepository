using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using Persistence.Dynamic;
using Persistence.Paging;
using System.Linq.Expressions;

namespace Application.Services.Repositories;

public interface IAsyncRepository<TEntity> : IQuery<TEntity>
    where TEntity : Entity
{
    Task<TEntity> GetAsync(
        Expression<Func<TEntity, bool>> predicate,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
        );

    Task<Paginate<TEntity>> GetListAsync(
        Expression<Func<TEntity, bool>> predicate,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
        );

    Task<Paginate<TEntity>> GetListByDynamicAsync(
      DynamicQuery dynamicQuery,
      Expression<Func<TEntity, bool>> predicate,
      Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
      Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
      int index = 0,
      int size = 10,
      bool withDeleted = false,
      bool enableTracking = true,
      CancellationToken cancellationToken = default
      );

    Task<bool> AnyAsync(
        Expression<Func<TEntity, bool>> predicate,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
        );

    Task<TEntity> AddAsync(TEntity entity);

    Task<ICollection<TEntity>> AddRangeAsync(ICollection<TEntity> entities);

    Task UpdateAsync(TEntity entity);

    Task UpdateRangeAsync(ICollection<TEntity> entities);

    Task<TEntity> DeleteAsync(TEntity entity, bool permanent = false);

    Task<ICollection<TEntity>> DeleteRangeAsync(ICollection<TEntity> entities, bool permenant = false);
}
