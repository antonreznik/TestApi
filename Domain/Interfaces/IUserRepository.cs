namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<UserEntity?> GetUserByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IEnumerable<UserEntity>> GetAllUsersAsync(CancellationToken cancellationToken = default);
        Task AddUserAsync(UserEntity user, CancellationToken cancellationToken = default);
        Task SaveAsync(CancellationToken cancellationToken = default);
        Task DeleteUserAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
