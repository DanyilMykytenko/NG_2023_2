using DataAccessLayer.Data;
using DataAccessLayer.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer
{
    public static class DataAccessLayerInjection
    {
        public static void Inject(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<CircusDatabaseContext>(options =>
            {
                options.UseSqlServer(
                    configuration["ConnectionString"]);
            });
            services.AddScoped<DbService>();
        }
    }
}
