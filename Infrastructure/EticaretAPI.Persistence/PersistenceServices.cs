using EticaretAPI.Application.Repositories.Customer;
using EticaretAPI.Application.Repositories.Order;
using EticaretAPI.Application.Repositories.Product;
using EticaretAPI.Persistence.Context;
using EticaretAPI.Persistence.Repositories.Customer;
using EticaretAPI.Persistence.Repositories.Order;
using EticaretAPI.Persistence.Repositories.Product;
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
        services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
        services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

        services.AddScoped<IOrderReadRepository, OrderReadRepository>();
        services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

        services.AddScoped<IProductReadRepository, ProductReadRepository>();
        services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
    }
}