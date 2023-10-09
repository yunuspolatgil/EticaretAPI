using EticaretAPI.Application.Repositories.Product;
using EticaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EticaretAPI.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    readonly private IProductReadRepository _productReadRepository;
    readonly private IProductWriteRepository _productWriteRepository;
    
    public ProductsController(IProductReadRepository productReadRepository,IProductWriteRepository productWriteRepository)
    {
        _productReadRepository = productReadRepository;
        _productWriteRepository = productWriteRepository;
    }
    
    [HttpGet]
    public async void Get()
    {
        await _productWriteRepository.AddRangeAsync(new()
        {
            new (){Id = Guid.NewGuid(),Name = "Telefon",Price = 1220,Stock = 12},
            new (){Id = Guid.NewGuid(),Name = "Bilgisayar",Price = 5200,Stock = 1},
            new (){Id = Guid.NewGuid(),Name = "Tablet",Price = 3500,Stock = 24},
            new (){Id = Guid.NewGuid(),Name = "Akıllı Saat",Price = 800,Stock = 4}
        });
        await _productWriteRepository.SaveAsync();
    }
}