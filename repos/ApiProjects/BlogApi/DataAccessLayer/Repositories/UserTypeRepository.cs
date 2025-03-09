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
    public class UserTypeRepository : IUserTypeRepository
    {
        public ApplicationDbContext _applicationDbcontext;

        //Constructor that injects the applicationDbContext object
        public UserTypeRepository(ApplicationDbContext applicationDbcontext)
        {
            _applicationDbcontext = applicationDbcontext;
        }

        // Creates a new UserType record in the database.
        public UserType Create(UserType userType)
        {
            _applicationDbcontext.UserTypes.Add(userType);
            _applicationDbcontext.SaveChanges();
            return userType;
        }

        // Deletes a UserType record from the database.
        public void Delete(UserType userType)
        {
            _applicationDbcontext.UserTypes.Remove(userType);
            _applicationDbcontext.SaveChanges();
        }

        // Retrieves a list of all UserType records from the database.
        public List<UserType> Get()
        {
            return _applicationDbcontext.UserTypes.ToList();
        }

        // Retrieves a specific UserType record by its ID.
        public UserType? Get(int id)
        {
            UserType userType = _applicationDbcontext.UserTypes.Find(id);
            return userType;
        }

        // Updates an existing UserType record in the database.
        public UserType? Update(UserType userType)
        {

            //Finding the like to update by the id
            UserType? existingUserType = _applicationDbcontext.UserTypes.Find(userType.Id);

            existingUserType.UserTypeName = userType.UserTypeName;

            //Updating the existing post and Saving the changes
            _applicationDbcontext.UserTypes.Update(existingUserType);
            _applicationDbcontext.SaveChanges();
            return existingUserType;
        }



    }


        

        
    
}
