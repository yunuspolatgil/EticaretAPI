using EticaretAPI.Domain.Entities.Common;

namespace EticaretAPI.Application.Repositories;

//Ekleme,Silme, Güncelleme
public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T model);
    Task<bool> AddRangeAsync(List<T> datas);
    bool Remove(T model);
    Task<bool> RemoveAsync(string id);
    bool RemoveRange(List<T> datas);
    bool UpdateAsync(T model);
    Task<int> SaveAsync();
}