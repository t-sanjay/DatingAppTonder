using Tonder.Data;
using Tonder.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tonder.Helpers;
using Tonder.Interfaces;
using Tonder.SignalR;

namespace Tonder.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton<PresenceTracker>();

            services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));

            //JWT configurations
            services.AddScoped<ITokenService, TokenService>();

            //Photo Upload and Delete
            services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<ILikesRepository, LikesRepository>();

            services.AddScoped<LogUserActivity>();

            services.AddScoped<IMessageRepository, MessageRepository>();
            //UserRepository
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

            //SQL server configuration
            services.AddDbContext<TonderDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("UserSQLString"));
            });

            return services;
        }
    }
}
