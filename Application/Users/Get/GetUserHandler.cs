using Application.Users.Common.Dto;
using Domain.Interfaces;

namespace Application.Users.Get
{
    public class GetUserHandler(IUserRepository userRepository) : IGetUserHandler
    {
        public async Task<UserOutputDto?> HandleAsync(Guid userId, CancellationToken cancellationToken = default)
        {
            var userEntity = await userRepository.GetUserByIdAsync(userId, cancellationToken);

            if (userEntity is null)
            {
                return default;
            }

            return new UserOutputDto(userEntity.Id,
                userEntity.FirstName,
                userEntity.LastName,
                userEntity.Email,
                userEntity.Age);
        }
    }
}
