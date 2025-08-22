using Domain.Interfaces;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static void AddPostgreSQLDbContext(this IServiceCollection services)
        {
            services.AddDbContext<UsersDbContext>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
