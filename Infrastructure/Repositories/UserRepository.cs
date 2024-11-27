using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Dal;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly UchebkaDbContext _dbContext;

    public UserRepository(
        UchebkaDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<bool> IsUniqueUser(string email, CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
        if (user == null)
            return false;

        return true;
    }
    
    public async Task<User> IsUserExistAsync(string email, CancellationToken cancellationToken)
    {
        var existUser = await _dbContext.Users.FirstOrDefaultAsync(
            u => u.Email == email, cancellationToken);

        if (existUser == null)
            return null;

        return existUser;
    }
    
    public async Task<User> AddAsync(User user, CancellationToken cancellationToken)
    {
        await _dbContext.AddAsync(user, cancellationToken);
        return user;
    }
    
    public Task<User> UpdateAsync(User user, CancellationToken cancellationToken)
    {
        _dbContext.Users.Update(user);
        return Task.FromResult(user);
    }
    
    public Task DeleteAsync(User entity, CancellationToken cancellationToken)
    {
        _dbContext.Users.Remove(entity);
        return Task.CompletedTask;
    }

    public async Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _dbContext.Users.FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
    }
    
    public async Task<List<User>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _dbContext.Users.ToListAsync(cancellationToken);
    }
    
    public Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        _dbContext.SaveChangesAsync(cancellationToken);
        return Task.CompletedTask;
    }
}