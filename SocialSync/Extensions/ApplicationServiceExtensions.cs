using Microsoft.EntityFrameworkCore;
using SocialSync.Data;
using SocialSync.Helpers;
using SocialSync.Interfaces;
using SocialSync.Repository;
using SocialSync.Repository.IRepository;
using SocialSync.Services;

namespace SocialSync.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IPhotoServices, PhotoService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));

            return services;
        }
    }
}
