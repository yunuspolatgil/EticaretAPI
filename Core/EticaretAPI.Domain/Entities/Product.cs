using EticaretAPI.Domain.Entities.Common;

namespace EticaretAPI.Domain.Entities;

public class Product:BaseEntity
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public long Price { get; set; }

    //Bir Product'un birden fazla order'i olur.
    public ICollection<Order> Orders { get; set; }
}