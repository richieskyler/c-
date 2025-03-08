using BusinessLogicLayer.IMapperMethodsInterface;
using BusinessLogicLayer.IServices;
using DataAccessLayer.Models;
using DomainLayer.DTO.CategoryDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]/[option]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public readonly ICategoryService _categoryService;
        public readonly ICategoryMapper _categoryMapper;

        public CategoryController(ICategoryService categoryService, ICategoryMapper categoryMapper)
        {
            _categoryService = categoryService;
            _categoryMapper = categoryMapper;
        }

        // Retrieves all categories and returns them as a list.
        [HttpGet]
        public IActionResult GetCategory()
        {
            return Ok(_categoryService.GetAllCategory());
        }

        // Retrieves a specific category by its ID and returns it as a CategoryDto.
        [HttpGet]
        public IActionResult GetById(int id)
        {
            Category? category = _categoryService.GetCategory(id);

            if (category == null)
            {
                return NotFound();
            }

            CategoryDto? categoryDto = _categoryMapper.MapCategoryToCategoryDto(category);
            return Ok(categoryDto);
        }

        // Creates a new category using the provided CreateCategoryRequestDto and returns the created category as a CategoryDto.
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryRequestDto createCategoryRequestDto)
        {
            Category mappedCategory = _categoryMapper.MapCreateCategoryRequesDtoCategory(createCategoryRequestDto);
            Category? createdCategory = _categoryService.CreateCategory(mappedCategory, out string message);

            if (createdCategory == null)
            {
                return BadRequest(message);
            }

            CategoryDto? mappedCategoryDto = _categoryMapper.MapCategoryToCategoryDto(createdCategory);
            return Ok(mappedCategoryDto);
        }

        // Updates an existing category using the provided UpdateCategoryRequestDto and returns the updated category as a CategoryDto.
        [HttpPost]
        public IActionResult UpdateCategory([FromBody] UpdateCategoryRequestDto updateCategoryRequestDto)
        {
            Category mappedCategory = _categoryMapper.MapUpdateCategoryRequestDtoToCategory(updateCategoryRequestDto);

            Category? categoryUpdated = _categoryService.UpdateCategory(mappedCategory, out string message);

            if (categoryUpdated is null)
            {
                return BadRequest(message);
            }

            CategoryDto? UpdatedCategoryDto = _categoryMapper.MapCategoryToCategoryDto(categoryUpdated);

            return Ok(UpdatedCategoryDto);
        }

        // Deletes a category using the provided DeleteCategoryRequestDto and returns a boolean indicating success or failure.
        [HttpDelete]
        public IActionResult DeleteCategory([FromBody] DeleteCategoryRequestDto deleteCategoryRequestDto)
        {
            Category mappedCategory = _categoryMapper.MapDeleteCategoryRequestDtoToCategory(deleteCategoryRequestDto);

            bool categoryDeleted = _categoryService.DeleteCategory(mappedCategory.Id, out string message);

            return Ok(categoryDeleted);
        }

    }
}
