using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Richard.Data;
using Richard.Models;

namespace Richard.Repository
{
    class ProductReprository
    {
        public readonly AppDbContext dbContext = new AppDbContext();

        public List<Product> Products()
        {
            return dbContext.Products.ToList();
        }

        public Product CreateProduct(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return product;
        }

        public Product? GetProduct(int id)
        {
            return dbContext.Products.Find(id);
        }

        public Product? UpdateProduct(int id, Product product)
        {
            Product? existingProduct = dbContext.Products.Find(id);

            if(existingProduct == null)
            {
                return null;
            }

            

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.Quantity = product.Quantity;
            existingProduct.CategoryId = product.CategoryId;
            existingProduct.CreatedAt = product.CreatedAt;

            dbContext.Products.Update(existingProduct);
            dbContext.SaveChanges();

            return product;
        }


        public void DeleteProduct(Product product )
        {
            dbContext.Remove(product);
            dbContext.SaveChanges();
        }
    }
}
