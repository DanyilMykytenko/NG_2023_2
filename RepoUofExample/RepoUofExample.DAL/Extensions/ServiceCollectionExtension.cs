using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepoUofExample.DAL.Repositories;
using RepoUofExample.DAL.Repositories.Interfaces;
using RepoUofExample.DAL.UoW;

namespace RepoUofExample.DAL.Extensions;

public static class ServiceCollectionExtension
{
    public static void ConfigureDataAccessServices(this IServiceCollection services)
    {
        services.AddRepositories();
    }

    public static void AddSqlDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RecipeContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("SqlConnection")));
    }

    private static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IRecipeRepository, RecipeRepository>();
        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<UnitOfWork>();
    }
}