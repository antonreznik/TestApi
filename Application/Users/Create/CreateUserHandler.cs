using Domain;
using Domain.Interfaces;

namespace Application.Users.Create
{
    public class CreateUserHandler(IUserRepository userRepository) : ICreateUserHandler
    {
        public Task HandleAsync(CreateUserCommand command, CancellationToken cancellationToken = default)
        {
            var user = UserEntity.CreateUser(command.FirstName, command.LastName, command.Email, command.Age);

            return userRepository.AddUserAsync(user, cancellationToken);
        }
    }
}
