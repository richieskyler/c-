using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IServices;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.Servcies
{
    public class CategoryService : ICategoryService
    {
        //Private variable that stores the ICategoryRepository object
        public readonly ICategoryRepository _categoryRepository;


        //Constructor of the CategoryService class
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category? CreateCategory(Category category, out string message)
        {
            if (string.IsNullOrWhiteSpace(category.Name))
            {
                message = "Name cannot be empty";
                return null;
            }

            if (string.IsNullOrWhiteSpace(category.Description))
            {
                message = "Dsescription cannot be emmpty";
                return null;
            }

            _categoryRepository.Create(category);
            message = "Category created Successfully";
            return category;
        }

        public bool DeleteCategory(int id, out string message)
        {
            if (id <= 0)
            {
                message = "Invalid";
                return false;
            }

            Category? category = _categoryRepository.Get(id);

            if (category == null)
            {
                message = "Return a Number";
                return false;
            }

            _categoryRepository.Delete(category);
            message = "Deleted Successfully";
            return true;
        }

        public List<Category> GetAllCategory()
        {
            return _categoryRepository.Get();
        }

        public Category? GetCategory(int id)
        {
            if (id <= 0)
            {
                return null;
            }
            return _categoryRepository.Get(id);
        }

        public Category? UpdateCategory(Category category, out string message)
        {
            if (category.Id <= 0)
            {
                message = "Invalid Id";
                return null;
            }

            if (string.IsNullOrWhiteSpace(category.Description))
            {
                message = "Description is Required";
                return null;
            }

            if (string.IsNullOrWhiteSpace(category.Name))
            {
                message = "Name is Required";
                return null;
            }

            Category? updatedCategory = _categoryRepository.Update(category);

            message = "Successfully Upated";
            return updatedCategory;
        }
    }
}
