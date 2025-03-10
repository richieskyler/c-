using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.IRepositories
{
    public interface IUserTypeRepository
    {
        /// <summary>
        /// Create UserType
        /// </summary>
        /// <param name="usertype"></param>
        /// <returns>UserType Object</returns>
        UserType Create(UserType usertype);

        /// <summary>
        /// List of UserType
        /// </summary>
        /// <returns>List of UserType</returns>
        List<UserType> Get();

        /// <summary>
        /// Update UserType Details
        /// </summary>
        /// <param name="usertype"></param>
        /// <returns>Updated Object</returns>
        UserType? Update(UserType usertype);

        /// <summary>
        /// Delete UserType
        /// </summary>
        /// <param name="usertype"></param>
        void Delete(UserType usertype);

        /// <summary>
        /// Get product Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>UserType Object by Id</returns>
        UserType? Get(int id);
    }
}
