using EticaretAPI.Application.Repositories.Product;
using EticaretAPI.Persistence.Context;

namespace EticaretAPI.Persistence.Repositories.Product;

public class ProductWriteRepository : WriteRepository<Domain.Entities.Product>,IProductWriteRepository
{
    public ProductWriteRepository(EticaretApiDbContext context) : base(context)
    {
    }
}