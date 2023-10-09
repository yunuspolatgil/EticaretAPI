using EticaretAPI.Application.Repositories.Product;
using EticaretAPI.Persistence.Context;

namespace EticaretAPI.Persistence.Repositories.Product;

public class ProductReadRepository : ReadRepository<Domain.Entities.Product>,IProductReadRepository
{
    public ProductReadRepository(EticaretApiDbContext context) : base(context)
    {
    }
}