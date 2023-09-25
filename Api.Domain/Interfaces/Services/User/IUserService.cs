using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<UserEntity> GetById(Guid id);
        Task<List<UserEntity>> GetAll();
        Task<UserEntity> Create(UserEntity user);
        Task<UserEntity> Update(UserEntity user);
        Task<bool> Delete(Guid id);
    }
}