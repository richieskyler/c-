using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.IServices
{
    public interface IUserService
    {
        /// <summary>
        ///     Get User object
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User object</returns>
        User? GetUser(int id);


        /// <summary>
        ///     Get all User in the database
        /// </summary>
        /// <returns>List of User Object</returns>
        List<User> GetAllUser();

        /// <summary>
        ///     Remove a User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteUser(int id, out string message);


        /// <summary>
        ///     Modify a User object
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Uodated Object</returns>
        User? UpdateUser(User user, out string message);


        /// <summary>
        ///     Create a User
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Create a new User object</returns>
        User? CreateUser(User user, out string message);

    }
}
