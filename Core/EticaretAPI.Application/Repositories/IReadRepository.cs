
using System.Linq.Expressions;
using EticaretAPI.Domain.Entities.Common;

namespace EticaretAPI.Application.Repositories;

//Select sorgu almak için
public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll();
    IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
    Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
    Task<T> GetByIdAsync(string id);
}