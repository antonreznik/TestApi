namespace Application.Users.Common.Dto
{
    public record UserOutputDto(Guid Id, string FirstName, string LastName, string Email, int Age);
}
