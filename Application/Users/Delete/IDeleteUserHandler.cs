namespace Application.Users.Delete
{
    public interface IDeleteUserHandler
    {
        Task HandleAsync(Guid Id, CancellationToken cancellationToken = default);
    }
}
