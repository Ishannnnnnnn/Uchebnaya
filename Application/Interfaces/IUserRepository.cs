using Domain.Entities;

namespace Application.Interfaces;

public interface IUserRepository : IBaseRepository<User>
{
    public Task<User> UpdateAsync(User user, CancellationToken cancellationToken);
    public Task DeleteAsync(User user, CancellationToken cancellationToken);
    public Task<bool> IsUniqueUser(string email, CancellationToken cancellationToken);
    public Task<User> IsUserExistAsync(string email, CancellationToken cancellationToken);
    public Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}