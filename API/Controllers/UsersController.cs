using Application.Users.Common.Dto;
using Application.Users.Create;
using Application.Users.Delete;
using Application.Users.Get;
using Application.Users.List;
using Application.Users.Update;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(
        IGetUserHandler getUserHandler,
        IGetUsersHandler getUsersHandler,
        ICreateUserHandler createUserHandler,
        IUpdateUserHandler updateUserHandler,
        IDeleteUserHandler deleteUserHandler) : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<UserOutputDto>> Get()
        {
            var users = await getUsersHandler.HandleAsync();

            return users;
        }

        [HttpGet("{userId}")]
        public async Task<UserOutputDto?> Get(Guid userId)
        {
            var user = await getUserHandler.HandleAsync(userId);

            return user;
        }

        [HttpPost]
        public Task Post([FromBody] CreateUserCommand command)
        {
            return createUserHandler.HandleAsync(command);
        }

        [HttpPut()]
        public Task Put([FromBody] UpdateUserCommand command)
        {
            return updateUserHandler.HandleAsync(command);
        }

        [HttpDelete("{userId}")]
        public Task DeleteAsync(Guid userId)
        {
            return deleteUserHandler.HandleAsync(userId);
        }
    }
}
