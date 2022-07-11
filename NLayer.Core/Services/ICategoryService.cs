using NLayer.Core.DTOs;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface ICategoryService : IServices<Category>
    {
     public   Task<CustomResponseDto<CategoryWithProductDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}
