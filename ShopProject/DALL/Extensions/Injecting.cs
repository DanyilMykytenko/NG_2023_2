using DAL.Context;
using DAL.Repository;
using DAL.Repository.Classes;
using DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Extensions
{
    public static class Injecting
    {
        public static void Inject(
        this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddDbContext<DBContext>(options =>
            {
                options.UseSqlServer(
                        configuration.GetConnectionString("SqlDatabase"));
            });
        }
    }
}
