namespace Application.Users.Create
{
    public record CreateUserCommand(string FirstName, string LastName, string Email, int Age);

}
