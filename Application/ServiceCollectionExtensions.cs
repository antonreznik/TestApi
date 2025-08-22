using Application.Users.Create;
using Application.Users.Delete;
using Application.Users.Get;
using Application.Users.List;
using Application.Users.Update;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateUserHandler, CreateUserHandler>();
            services.AddScoped<IUpdateUserHandler, UpdateUserHandler>();
            services.AddScoped<IGetUserHandler, GetUserHandler>();
            services.AddScoped<IGetUsersHandler, GetUsersHandler>();
            services.AddScoped<IDeleteUserHandler, DeleteUserHandler>();
        }
    }
}
