using EticaretAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EticaretAPI.Persistence.Context;

public class EticaretApiDbContext : DbContext
{
    public EticaretApiDbContext(DbContextOptions<EticaretApiDbContext> options):base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
}

//docker run --name some-postgres -p 5432:5432 -e POSTGRES_PASSWORD=mysecretpassword -d postgres