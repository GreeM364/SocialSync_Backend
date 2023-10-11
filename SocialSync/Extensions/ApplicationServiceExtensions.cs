using Microsoft.EntityFrameworkCore;
using SocialSync.Data;
using SocialSync.Helpers;
using SocialSync.Services;
using SocialSync.Services.Interfaces;
using SocialSync.SignalR;
using SocialSync.UnitOfWorks;
using SocialSync.UnitOfWorks.Interfaces;

namespace SocialSync.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IPhotoServices, PhotoService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<PresenceTracker>();

            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));
            services.AddScoped<LogUserActivity>();
            services.AddSignalR();

            return services;
        }
    }
}
