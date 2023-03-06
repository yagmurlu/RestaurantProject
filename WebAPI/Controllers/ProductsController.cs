using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public List<Product> Get()
        {
            return new List<Product>
            {
                new Product { ProductId = 3, ProductName = "Ezogelin" },
                new Product { ProductId = 4, ProductName = "Mercimek" }
            };
        }
    }
}
