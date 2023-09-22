using Api.Domain.Entities;

namespace Api.Domain.Interfaces
{

    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> CreateAsync(TEntity item);
        Task<TEntity> UpdateAsync(TEntity item);
        Task<bool> DeleteAsync(Guid id);
        Task<TEntity> GetAsync(Guid id);
        Task<List<TEntity>> GetAllAsync();
    }
}