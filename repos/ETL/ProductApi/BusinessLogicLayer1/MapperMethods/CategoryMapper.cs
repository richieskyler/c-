using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.DTO;
using DomainLayer.Models;

namespace BusinessLogicLayer.MapperMethods
{
    public class CategoryMapper
    {
        public Category MapCategoryRequestToCategory(CreateRequestCategoryDto createRequestCategoryDto)
        {
            return new Category
            {
                Name = createRequestCategoryDto.Name,
                Description = createRequestCategoryDto.Description,
            };
        }

        public CategoryDto MapCategoryToCategoryDto(Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                CreatedAt = category.CreatedAt,
                UpdatedAt = category.UpdateAt
            };
        }
    }
}
