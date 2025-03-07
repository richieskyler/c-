using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Data;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext _applicationDbContext;

        //Constructor that injects the applicationDbContext object
        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Category Create(Category category)
        {
            _applicationDbContext.Categories.Add(category);
            _applicationDbContext.SaveChanges();
            return category;
        }

        public void Delete(Category category)
        {
            _applicationDbContext.Remove(category);
            _applicationDbContext.SaveChanges();
        }

        public List<Category> Get()
        {
            return 
        }

        public Category? Get(int id)
        {
            throw new NotImplementedException();
        }

        public Category? Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
