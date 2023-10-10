using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly string[] productNames = { "ebook", "encapsulado", "curso" };
        private readonly string[] brands = { "Natura", "Adidas", "Magalu" };
        private readonly string[] categories = { "fisico", "digital", "servico" };

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProductData")]
        public IEnumerable<Product> Get()
        {
            var products = GenerateProducts(100);
            return products;
        }

        [HttpGet("category/{category}", Name = "GetProductsByCategory")]
        public IEnumerable<Product> GetByCategory(string category)
        {
            var products = GenerateProducts(100).Where(p => p.Category == category);
            return products;
        }

        [HttpGet("brand/{brand}", Name = "GetProductsByBrand")]
        public IEnumerable<Product> GetByBrand(string brand)
        {
            var products = GenerateProducts(100).Where(p => p.Brand == brand);
            return products;
        }

        [HttpGet("categories")]
        public IActionResult GetCategories()
        {
            return Ok(categories);
        }

        [HttpGet("brands")]
        public IActionResult GetBrands()
        {
            return Ok(brands);
        }

        // Método privado para gerar produtos fictícios
        private IEnumerable<Product> GenerateProducts(int count)
        {
            var products = new List<Product>();
            var random = new Random();

            for (int i = 1; i <= count; i++)
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
}
