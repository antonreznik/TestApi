using Domain.Interfaces;

namespace Application.Users.Delete
{
    internal class DeleteUserHandler(IUserRepository userRepository) : IDeleteUserHandler
    {
        public Task HandleAsync(Guid Id, CancellationToken cancellationToken = default)
        {
            return userRepository.DeleteUserAsync(Id, cancellationToken);
        }
    }
}
