using EticaretAPI.Application.Abstructure;
using EticaretAPI.Persistence.Constcrete;
using EticaretAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EticaretAPI.Persistence;

public static class PersistenceServices
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<EticaretApiDbContext>(options =>
        {
            options.UseNpgsql(Configuration.ConnectionString);
        });
        services.AddSingleton<IProductService, ProductService>();
    }
}