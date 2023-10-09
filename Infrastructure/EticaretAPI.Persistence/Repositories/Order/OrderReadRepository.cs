using EticaretAPI.Application.Repositories.Order;
using EticaretAPI.Persistence.Context;

namespace EticaretAPI.Persistence.Repositories.Order;

public class OrderReadRepository : ReadRepository<Domain.Entities.Order>,IOrderReadRepository
{
    public OrderReadRepository(EticaretApiDbContext context) : base(context)
    {
    }
}