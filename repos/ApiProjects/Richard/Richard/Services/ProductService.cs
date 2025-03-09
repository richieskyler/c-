using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Richard.Models;
using Richard.Repository;

namespace Richard.Services
{
    class ProductService
    {
        ProductReprository productReprository = new ProductReprository();
        CategoryRepository categoryRepository = new CategoryRepository();

        public List<Product> Products()
        {
            return productReprository.Products();
        }


        public Product? CreateProduct(Product product, out string message)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
            {
                message = "Invalid Name";
                return null;
            }

            if(string.IsNullOrWhiteSpace(product.Description))
            {
                message = "Invalid Name";
                return null;
            }

            if (product.Price < 0)
            {
                message = "Invalid Price";
                return null;
            }

            if (product.Quantity < 0)
            {
                message = "Invalid";
                return null;
            }

            Category? category = categoryRepository.GetCategory(product.CategoryId);

            if (category == null)
            {
                message = "Not found";
                return null;
            }

            Product? result = productReprository.CreateProduct(product);
            message = "Created Successful";
            return result;
        }

        public List<Product> products()
        {
            return productReprository.Products();
        }

        public bool DeleteProduct(int id, out string message)
        {
            if (id <= 0)
            {
                message = "Invalid Id";
                return false;
            }

            Product? product = productReprository.GetProduct(id);
            if(product == null)
            {
                message = "Not found";
                return false;
            }

            productReprository.DeleteProduct(product);
            message = "Deleted Successfully";
            return true;
        }

        public Product GetProduct(int id, out string message)
        {
            if (id <= 0)
            {
                message = "Invalid Id";
                return null;
            }

            Product? product = productReprository.GetProduct(id);

            if (product == null)
            {
                message = "Not found";
                return null;
            }

            message = "Successful";
            return product;

        }


    }
}
