using Application.Users.Common.Dto;
using Domain.Interfaces;

namespace Application.Users.List
{
    public class GetUsersHandler(IUserRepository userRepository) : IGetUsersHandler
    {
        public async Task<IEnumerable<UserOutputDto>> HandleAsync(CancellationToken cancellationToken = default)
        {
            var users = (await userRepository.GetAllUsersAsync(cancellationToken)).Select(u => new UserOutputDto(u.Id,
                u.FirstName,
                u.LastName,
                u.Email,
                u.Age));

            return users;
        }
    }
}
