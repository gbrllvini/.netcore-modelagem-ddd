using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<UserEntity> _repository;
        public UserService(IRepository<UserEntity> repository)
        {
            _repository = repository;
        }

        public async Task<UserEntity> Create(UserEntity user)
        {
            return await _repository.CreateAsync(user);
        }

        public async Task<UserEntity?> Update(UserEntity user)
        {
            return await _repository.UpdateAsync(user);
        }


        public async Task<List<UserEntity>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<UserEntity?> GetById(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }


    }
}