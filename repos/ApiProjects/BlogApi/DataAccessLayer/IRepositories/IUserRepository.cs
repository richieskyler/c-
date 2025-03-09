using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.IRepositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// Create User
        /// </summary>
        /// <param name="user"></param>
        /// <returns>User Object</returns>
        User Create(User user);

        /// <summary>
        /// List of User
        /// </summary>
        /// <returns>List of User</returns>
        List<User> Get();

        /// <summary>
        /// Update User Details
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Updated Object</returns>
        User? Update(User user);

        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="user"></param>
        void Delete(User user);

        /// <summary>
        /// Get product Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User Object by Id</returns>
        User? Get(int id);
    }
}
