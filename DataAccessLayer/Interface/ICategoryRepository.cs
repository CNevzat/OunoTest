using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer.Interface;

public interface ICategoryRepository
{
    Task<Category?> GetCategoryAsync(int id);
}