using Microsoft.AspNetCore.Mvc;
using MyASPNETWebApp.Models;
using System.Collections.Generic;

namespace MyASPNETWebApp.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Iphone 15 Pro Max", Price = 1000.99m },
            new Product { Id = 2, Name = "MacBook Air", Price = 1500.50m },
            new Product { Id = 3, Name = "Microsoft Surface 9 Laptop", Price = 700.75m },
            new Product { Id = 4, Name = "Samsung Galaxy Tab 6", Price = 500.75m },
            

        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }
    }
}
