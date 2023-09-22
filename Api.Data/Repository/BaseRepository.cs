using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Repository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly MyContext _context;
        protected readonly DbSet<TEntity> _dataset;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataset = _context.Set<TEntity>();
        }

        public async Task<TEntity> CreateAsync(TEntity item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }

                item.CreateAt = DateTime.UtcNow;
                _dataset.Add(item);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return item;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> UpdateAsync(TEntity item)
        {
            throw new NotImplementedException();
        }
    }
}