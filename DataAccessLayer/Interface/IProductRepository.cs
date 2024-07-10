using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsByCategory(int categoryId);
    }
}