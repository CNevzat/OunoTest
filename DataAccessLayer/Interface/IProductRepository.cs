using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer.Repository
{
    public interface IProduct
    {
        Task<Product> GetProductAsync(int id);
    }
}