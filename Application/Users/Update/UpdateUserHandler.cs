using Domain.Interfaces;

namespace Application.Users.Update
{
    public class UpdateUserHandler(IUserRepository userRepository) : IUpdateUserHandler
    {
        public async Task HandleAsync(UpdateUserCommand command, CancellationToken cancellationToken = default)
        {
            var user = await userRepository.GetUserByIdAsync(command.Id, cancellationToken);

            user?.Update(command.FirstName, command.LastName, command.Email, command.Age);

            await userRepository.SaveAsync(cancellationToken);
        }
    }
}
