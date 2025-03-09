using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IMapperMethodsInterface;
using DataAccessLayer.Models;
using DomainLayer.DTO.UserTypeDto;

namespace BusinessLogicLayer.MapperMethods
{
    public class UserTypeMapper : IUserTypeMapper
    {
        // Maps a CreateUserTypeRequestDto to a UserType entity for creating a new user type.
        public UserType MapCreateUserTypeRequesDtoUserType(CreateUserTypeRequestDto createUserTypeRequestDto)
        {
            return new UserType
            {
                UserTypeName = createUserTypeRequestDto.UserTypeName,
                CreatedAt = DateTime.UtcNow
            };
        }

        // Maps a DeleteUserTypeRequestDto to a UserType entity for deleting an existing user type.
        public UserType MapDeleteUserTypeRequestDtoToUserType(DeleteUserTypeRequestDto deleteUserTypeRequestDto)
        {
            return new UserType
            {
                Id = deleteUserTypeRequestDto.Id
            };
        }

        // Maps an UpdateUserTypeRequestDto to a UserType entity for updating an existing user type.
        public UserType MapUpdateUserTypeRequestDtoToUserType(UpdateUserTypeRequestDto updateUserTypeRequestDto)
        {
            return new UserType
            {
                Id = updateUserTypeRequestDto.Id,
                UserTypeName = updateUserTypeRequestDto.UserTypeName,
                UpdatedAt = DateTime.UtcNow
            };
        }

        // Maps a UserType entity to a UserTypeDto for returning user type data.
        public UserTypeDto? MapUserTypeToUserTypeDto(UserType userType)
        {
            return new UserTypeDto
            {
                Id = userType.Id,
                UserTypeName = userType.UserTypeName,
                UpdatedAt = userType.UpdatedAt,
                CreatedAt = userType.CreatedAt
            };
        }
    }
}
