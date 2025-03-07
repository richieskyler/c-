using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Richard.Data;
using Richard.Models;


namespace Richard.Repository

{
    class CategoryRepository
    {
        public readonly AppDbContext dbContext = new AppDbContext();

        //method to fetch all the record in the category table
        public List<Category> Categories()
        {
            return dbContext.Categories.ToList();
        }

        public Category CreateCategory(Category cateogory)
        {
            dbContext.Categories.Add(cateogory);
            dbContext.SaveChanges();
            return cateogory;
        }

        public Category? GetCategory(int id)
        {
            return dbContext.Categories.Find(id);
        }

        public Category? UpdateCategory(int id, Category category)
        {
            Category? existingCategory = dbContext.Categories.Find(id);

            if(existingCategory == null)
            {
                return null; 
            }

            existingCategory.Name = category.Name;
            existingCategory.Description = category.Description;

            dbContext.Categories.Update(existingCategory);
            dbContext.SaveChanges();

            return existingCategory;
        }

        public void DeleteCategory(Category category)
        {
            dbContext.Remove(category);
            dbContext.SaveChanges();
        }
    }
}
