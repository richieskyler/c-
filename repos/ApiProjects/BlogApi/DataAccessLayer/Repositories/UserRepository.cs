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
    public class UserRepository : IUserRepository
    {
        //private readonly ApplicationDbContext applicationDbContext;
        private ApplicationDbContext _applicationDbContext;


        //Constructor that injects the applicationDbContext object
        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        // Adds a new user to the database and returns the created user.
        public User Create(User user)
        {
            _applicationDbContext.Users.Add(user);
            _applicationDbContext.SaveChanges();
            return user;
        }


        // Removes a user from the database.
        public void Delete(User user)
        {
            _applicationDbContext.Users.Remove(user);
            _applicationDbContext.SaveChanges();
        }


        // Retrieves a list of all users from the database.
        public List<User> Get()
        {
            return _applicationDbContext.Users.ToList();
        }


        // Retrieves a specific user by their ID.
        public User? Get(int id)
        {
            User? user = _applicationDbContext.Users.Find(id);
            return user;
        }


        // Updates an existing user in the database and returns the updated user.
        public User? Update(User user)
        {

            // Retrieves a specific User record by its ID.
            User? existingUser = _applicationDbContext.Users.Find(user.Id);

            existingUser.Name = user.Name;
            existingUser.Email = existingUser.Email;

            //Updating the existing user and Saving the changes
            _applicationDbContext.Users.Update(existingUser);
            _applicationDbContext.SaveChanges();

            return existingUser;
        }
    }
}
