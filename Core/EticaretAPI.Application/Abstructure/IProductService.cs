using EticaretAPI.Domain.Entities;

namespace EticaretAPI.Application.Abstructure;

public interface IProductService
{
    List<Product> getProducts();
}