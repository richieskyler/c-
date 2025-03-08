using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IMapperMethodsInterface;
using DataAccessLayer.Models;
using DomainLayer.DTO.CategoryDto;

namespace BusinessLogicLayer.MapperMethods
{
    public class CategoryMapper : ICategoryMapper
    {

        public CategoryDto? MapCategoryToCategoryDto(Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                CreatedAt = category.CreatedAt,
                UpdatedAt = category.UpdatedAt
            };
        }

        public Category MapUpdateCategoryRequestDtoToCategory(UpdateCategoryRequestDto updateCategoryRequestDto)
        {
            return new Category
            {
                Id = updateCategoryRequestDto.Id,
                Name = updateCategoryRequestDto.Name,
                Description = updateCategoryRequestDto.Description,

            };
        }

        public Category MapDeleteCategoryRequestDtoToCategory(DeleteCategoryRequestDto deleteCategoryRequestDto)
        {
            return new Category
            {
                Id = deleteCategoryRequestDto.Id
            };
        }

        public Category MapCreateCategoryRequesDtoCategory(CreateCategoryRequestDto createCategoryRequestDto)
        {
            return new Category
            {
                Name = createCategoryRequestDto.Name,
                Description = createCategoryRequestDto.Description,
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}
