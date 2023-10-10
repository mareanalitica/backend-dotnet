using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly string[] productNames = { "ebook", "encapsulado", "curso" };
    private readonly string[] brands = { "João", "Marcos", "Luiza" };
    private readonly string[] categories = { "fisico", "digital" };
    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetProductData")]
    public IEnumerable<Product> Get()
    {
        var products = new List<Product>();
        var random = new Random();


        for (int i = 1; i <= 20; i++)
        {
            var year = random.Next(2000, 2023);
            var month = random.Next(1, 13);
            var productName = productNames[random.Next(productNames.Length)];
            var brandName = brands[random.Next(brands.Length)];
            var category = categories[random.Next(categories.Length)];
            products.Add(new Product
            {
                Name = productName,
                Category = category,
                Month = month,
                Year = year,
                Total = i * 100,
                Price = (decimal)(i * 9.99),
                Brand = brandName
            });
        }

        return products;
    }
}
