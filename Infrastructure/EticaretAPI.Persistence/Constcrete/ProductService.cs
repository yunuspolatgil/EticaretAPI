using EticaretAPI.Application.Abstructure;
using EticaretAPI.Domain.Entities;

namespace EticaretAPI.Persistence.Constcrete;

public class ProductService:IProductService
{
    public List<Product> getProducts()
        => new()
        {
            new() { Id = Guid.NewGuid(), Name = "Telefon", Stock = 2, Price = 1200 }
        };
}