namespace Application.Users.Update
{
    public record UpdateUserCommand(Guid Id,
        string FirstName,
        string LastName,
        string Email,
        int Age);
}
