using EticaretAPI.Application.Repositories.Order;
using EticaretAPI.Persistence.Context;

namespace EticaretAPI.Persistence.Repositories.Order;

public class OrderWriteRepository : WriteRepository<Domain.Entities.Order>,IOrderWriteRepository
{
    public OrderWriteRepository(EticaretApiDbContext context) : base(context)
    {
    }
}