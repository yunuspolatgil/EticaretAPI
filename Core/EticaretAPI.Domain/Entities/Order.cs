using EticaretAPI.Domain.Entities.Common;

namespace EticaretAPI.Domain.Entities;

public class Order:BaseEntity
{
    public string Description { get; set; }
    public string Address { get; set; }
    public Guid CustomerId { get; set; }
    
    //Bir orderin birden çok product olabilir.
    public ICollection<Product> Products { get; set; }
    
    //Bir Order'in sadece bir Customer'i olabilir
    public Customer Customer { get; set; }
}