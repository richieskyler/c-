using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IServices;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Servcies
{
    public class UserService : IUserService
    {
        //Private variable that stores the IUserRepository object
        public readonly IUserRepository _userRepository;

        //Constructor of the UserService class
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User? CreateUser(User user, out string message)
        {
            if(string.IsNullOrWhiteSpace(user.Name))
            {
                message = "Name cannot be empty";
                return null;
            }

            if(string.IsNullOrWhiteSpace(user.Email))
            {
                message = "Email cannot be empty";
                return null;
            }

            if(user.UserTypeId <= 0)
            {
                message = "Invalid userTypeId";
                return null;
            }

            _userRepository.Create(user);
            message = "Created";
            return user;
        }

        public bool DeleteUser(int id, out string message)
        {
            if (id <= 0)
            {
                message = "Invalid Id";
                return false;
            }

            User? user = _userRepository.Get(id);

            if (user is null)
            {
                message = "Id cannot be found";
                return false;
            }

            _userRepository.Delete(user);
            message = "User Deleted Successfully";
            return true;
        }

        public List<User> GetAllUser()
        {
            return _userRepository.Get();
        }

        public User? GetUser(int id)
        {
            if (id <= 0)
            {
                return null;
            }
            return _userRepository.Get(id);
        }

        public User? UpdateUser(User user, out string message)
        {
            if (user.Id <= 0)
            {
                message = "Invalid Id";
                return null;
            }

            if (string.IsNullOrWhiteSpace(user.Name))
            {
                message = "Name is Required";
                return null;
            }

            if (string.IsNullOrWhiteSpace(user.Email))
            {
                message = "Email is Required";
                return null;
            }

            if (user.UserTypeId <= 0)
            {
                message = "Invalid UserType Id";
                return null;
            }



            User? updatedUser = _userRepository.Update(user);

            message = "Successfully Upated";
            return updatedUser;
        }
    }
}
