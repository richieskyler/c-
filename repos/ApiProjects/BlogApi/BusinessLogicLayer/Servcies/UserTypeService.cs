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
    public class UserTypeService : IUserTypeService
    {
        //Private variable that stores the IUserTypeRepository object
        public readonly IUserTypeRepository _userTypeRepository;

        //Constructor of the UserTypeService class
        public UserTypeService(IUserTypeRepository userTypeRepository)
        {
            _userTypeRepository = userTypeRepository;
        }

            public UserType? CreateUserType(UserType userType, out string message)
        {
            if (string.IsNullOrWhiteSpace(userType.UserTypeName))
            {
                message = "UserTypeName cannot be empty";
                return null;
            }

            _userTypeRepository.Create(userType);
            message = "UserType created";
            return userType;
        }

        public bool DeleteUserType(int id, out string message)
        {
            if (id <= 0)
            {
                message = "Invalid Id";
                return false;
            }

            UserType? userType = _userTypeRepository.Get(id);

            if (userType is null)
            {
                message = "Id cannot be found";
                return false;
            }

            _userTypeRepository.Delete(userType);
            message = "UserType Deleted Successfully";
            return true;
        }

        public List<UserType> GetAllUserType()
        {
            return _userTypeRepository.Get();
        }

        public UserType? GetUserType(int id)
        {
            if (id <= 0)
            {
                return null;
            }
            return _userTypeRepository.Get(id);
        }

        public UserType? UpdateUserType(UserType userType, out string message)
        {

            if (string.IsNullOrWhiteSpace(userType.UserTypeName))
            {
                message = "Name is Required";
                return null;
            }
            UserType? updatedUserType = _userTypeRepository.Update(userType);

            message = "Successfully Upated";
            return updatedUserType;

        }
    }
}
