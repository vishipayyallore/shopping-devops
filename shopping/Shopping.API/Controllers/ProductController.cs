using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shopping.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductContext _productContext;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ProductContext productContext, ILogger<ProductController> logger)
        {
            _productContext = productContext ?? throw new ArgumentNullException(nameof(productContext));

            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _productContext
                            .Products
                            .Find(p => true)
                            .ToListAsync();

            // Version 2
            // return ProductContext.Products;

            //var rnd = new Random();
            //return Enumerable.Range(1, 5)
            //    .Select(index => new Product { Id = $"{index}", Name = $"Product {index}" })
            //    .ToArray();
        }

    }

}

// Version 1
//[HttpGet]
//public IEnumerable<Product> Get()
//{
//    var rnd = new Random();

//    return Enumerable.Range(1, 5)
//        .Select(index => new Product { Id = $"{index}", Name = $"Product {index}" })
//        .ToArray();
//}
