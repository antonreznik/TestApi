

namespace Application.Users.Update
{
    public interface IUpdateUserHandler
    {
        Task HandleAsync(UpdateUserCommand command, CancellationToken cancellationToken = default);
    }
}
