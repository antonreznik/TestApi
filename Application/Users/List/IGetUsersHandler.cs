using Application.Users.Common.Dto;

namespace Application.Users.List
{
    public interface IGetUsersHandler
    {
        Task<IEnumerable<UserOutputDto>> HandleAsync(CancellationToken cancellationToken = default);
    }
}
