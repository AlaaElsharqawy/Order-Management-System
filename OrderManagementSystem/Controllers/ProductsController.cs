using Microsoft.AspNetCore.Mvc;

using System.Core.Entities;
using System.Core.Interfaces.Repositories;

namespace OrderManagementSystem.APIs.Controllers
{

    public class ProductsController : ApiBaseController
    {
        private readonly IGenericRepository<Product> _productRepo;

        public ProductsController(IGenericRepository<Product> ProductRepo)
        {
            _productRepo = ProductRepo;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProductsAsync()
        {
            var Products = await _productRepo.GetAllAsync();

            return Ok(Products);
        }

        [HttpGet("{ProductId}")]

        public async Task<ActionResult<Product>> GetDetailsOfSpecificProductAsync(int ProductId)
        {
            var Product = await _productRepo.GetByIdAsync(ProductId);
            return Ok(Product);
        }


        //[HttpPost]
        //public async Task AddNewProductAsync(Product product)
        //{
        //    var NewProduct = await _productRepo.AddAsync(product);


        //}

    }
}
