using EticaretAPI.Application.Repositories.Customer;
using EticaretAPI.Persistence.Context;

namespace EticaretAPI.Persistence.Repositories.Customer;

public class CustomerReadRepository : ReadRepository<Domain.Entities.Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(EticaretApiDbContext context) : base(context)
    {
    }
}