using EticaretAPI.Application.Repositories.Customer;
using EticaretAPI.Persistence.Context;

namespace EticaretAPI.Persistence.Repositories.Customer;

public class CustomerWriteRepository : WriteRepository<Domain.Entities.Customer>,ICustomerWriteRepository
{
    public CustomerWriteRepository(EticaretApiDbContext context) : base(context)
    {
    }
}