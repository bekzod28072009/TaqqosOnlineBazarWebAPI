using Microsoft.EntityFrameworkCore;
using Taqqos.DataAcces.AppDBContexts;

namespace TaqqosOnlineBazarWebAPI.Extension
{
    public static class Middleware
    {
        public static void AddDBConTextes(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                  options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
