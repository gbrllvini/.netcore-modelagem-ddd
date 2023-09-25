using Api.Domain.Entities;

namespace Api.Domain.Interfaces
{

    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<bool> ExistAsync(Guid id);
        Task<TEntity> CreateAsync(TEntity item);
        Task<TEntity?> UpdateAsync(TEntity item);
        Task<bool> DeleteAsync(Guid id);
        Task<TEntity?> GetByIdAsync(Guid id);
        Task<List<TEntity>> GetAllAsync();
    }
}