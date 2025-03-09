using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DomainLayer.DTO.UserTypeDto;

namespace BusinessLogicLayer.IMapperMethodsInterface
{
    public interface IUserTypeMapper
    {
        /// <summary>
        ///    Converts the UserTyperequestDto object to a UserType object
        /// </summary>
        /// <param name="createUserTypeRequestDto"></param>
        /// <returns>a UserType object</returns>
        UserType MapCreateUserTypeRequesDtoUserType(CreateUserTypeRequestDto createUserTypeRequestDto);

        /// <summary>
        /// Converts the UserType object to a UserTypeDto object
        /// </summary>
        /// <param name="userType"></param>
        /// <returns></returns>
        public UserTypeDto? MapUserTypeToUserTypeDto(UserType userType);

        /// <summary>
        /// Converts the UpdateUserTypeRequestDto object to UserType Object
        /// </summary>
        /// <param name="updateUserTypeRequestDto"></param>
        /// <returns></returns>
        public UserType MapUpdateUserTypeRequestDtoToUserType(UpdateUserTypeRequestDto updateUserTypeRequestDto);

        /// <summary>
        /// Converts the DeleteUserTypeRequestDto to UserType object
        /// </summary>
        /// <param name="deleteUserTypeRequestDto"></param>
        /// <returns></returns>
        public UserType MapDeleteUserTypeRequestDtoToUserType(DeleteUserTypeRequestDto deleteUserTypeRequestDto);
    }
}
