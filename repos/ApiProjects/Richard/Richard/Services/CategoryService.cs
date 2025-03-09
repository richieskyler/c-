using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Richard.Models;
using Richard.Repository;

namespace Richard.Services
{
    class CategoryService
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        public Category? CreateCategory(Category category, out string message)
        {
            if (string.IsNullOrWhiteSpace(category.Name))
            {
                message = "Invalid name";
                return null;
            }

            if (string.IsNullOrWhiteSpace(category.Description))
            {
                message = "Invalid description";
                return null;
            }

            Category? result = categoryRepository.CreateCategory(category);

            message = "Created successfuly";
            return result;

        }

        public List<Category> Categories()
        {
            return categoryRepository.Categories();
        }

        public bool DeleteCategory(int id, out string message)
        {
            if(id <= 0)
            {
                message = "invalid id";
                return false;
            }

            Category? category = categoryRepository.GetCategory(id);

            if(category == null)
            {
                message = "Not found";
                return false;
            }


            categoryRepository.DeleteCategory(category);
            message = "Deleted Successfully";
            return true;

        }

        public Category GetCategory(int id, out string message)
        {
            if (id <= 0)
            {
                message = "Invalid Id";
                return null;
            }

            Category? category = categoryRepository.GetCategory(id);
            
            if(category == null)
            {
                message = "Not found";
                return null;
            }

            message = "Successfull";
            return category;
        }

        













        
    }
}
