using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Product>> GetAllProducts(int categoryId)
        {
            var products =  await _applicationDbContext.Products
            .Where(x=> x.CategoryId == categoryId)
            .ToListAsync();

            return products;
        }
    }
}