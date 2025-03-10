using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.IServices
{
    public interface IUserTypeService
    {
        /// <summary>
        ///     Get UserType object
        /// </summary>
        /// <param name="id"></param>
        /// <returns>UserType object</returns>
        UserType? GetUserType(int id);


        /// <summary>
        ///     Get all UserType in the database
        /// </summary>
        /// <returns>List of UserType Object</returns>
        List<UserType> GetAllUserType();

        /// <summary>
        ///     Remove a UserType
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteUserType(int id, out string message);


        /// <summary>
        ///     Modify a UserType object
        /// </summary>
        /// <param name="userType"></param>
        /// <returns>Uodated Object</returns>
        UserType? UpdateUserType(UserType userType, out string message);


        /// <summary>
        ///     Create a UserType
        /// </summary>
        /// <param name="userType"></param>
        /// <returns>Create a new UserType object</returns>
        UserType? CreateUserType(UserType userType, out string message);

    }
}
