using EticaretAPI.Application.Abstructure;
using Microsoft.AspNetCore.Mvc;

namespace EticaretAPI.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : Controller
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var products = _productService.getProducts();
        return Ok(products);
    }
}