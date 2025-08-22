namespace Application.Users.Create
{
    public interface ICreateUserHandler
    {
        Task HandleAsync(CreateUserCommand command, CancellationToken cancellationToken = default);
    }
}
