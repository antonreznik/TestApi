using Application.Users.Common.Dto;

namespace Application.Users.Get
{
    public interface IGetUserHandler
    {
        Task<UserOutputDto?> HandleAsync(Guid userId, CancellationToken cancellationToken = default);
    }
}
