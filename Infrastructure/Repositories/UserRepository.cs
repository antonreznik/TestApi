
using Domain;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class UserRepository(UsersDbContext usersDbContext) : IUserRepository
    {
        public async Task AddUserAsync(UserEntity user, CancellationToken cancellationToken = default)
        {
            await usersDbContext.Users.AddAsync(user, cancellationToken);

            await SaveAsync(cancellationToken);
        }

        public async Task DeleteUserAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var user = await usersDbContext.Users.SingleAsync(u => u.Id == id, cancellationToken: cancellationToken);

            usersDbContext.Remove(user);

            await SaveAsync(cancellationToken);
        }

        public async Task<IEnumerable<UserEntity>> GetAllUsersAsync(CancellationToken cancellationToken = default)
        {
            var users = await usersDbContext.Users.ToListAsync(cancellationToken: cancellationToken);

            return users;
        }

        public async Task<UserEntity?> GetUserByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var user = await usersDbContext.Users.SingleAsync(u => u.Id == id, cancellationToken: cancellationToken);

            return user;
        }

        public Task SaveAsync(CancellationToken cancellationToken = default)
        {
            return usersDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
