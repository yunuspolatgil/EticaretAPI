using EticaretAPI.Domain.Entities.Common;

namespace EticaretAPI.Domain.Entities;

public class Customer:BaseEntity
{
    public string FullName { get; set; }
    //Bir Customer'in birden fazla Order'i olabilir.
    public ICollection<Order> Orders { get; set; }
}