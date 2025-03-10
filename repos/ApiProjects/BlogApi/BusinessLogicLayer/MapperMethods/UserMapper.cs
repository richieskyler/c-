using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IMapperMethodsInterface;
using DataAccessLayer.Models;
using DomainLayer.DTO.UserDto;

namespace BusinessLogicLayer.MapperMethods
{
    public class UserMapper : IUserMapper
    {
        // Maps a CreateUserRequestDto to a User entity for creating a new user.
        public User MapCreateUserRequesDtoUser(CreateUserRequestDto createUserRequestDto)
        {
            return new User
            {
                Name = createUserRequestDto.Name,
                Email = createUserRequestDto.Email,
                UserTypeId = createUserRequestDto.UserTypeId,
                CreatedAt = DateTime.UtcNow
            };
        }

        // Maps a DeleteUserRequestDto to a User entity for deleting an existing user.
        public User MapDeleteUserRequestDtoToUser(DeleteUserRequestDto deleteUserRequestDto)
        {
            return new User
            {
                Id = deleteUserRequestDto.Id
            };
        }

        // Maps an UpdateUserRequestDto to a User entity for updating an existing user.
        public User MapUpdateUserRequestDtoToUser(UpdateUserRequestDto updateUserRequestDto)
        {
            return new User
            {
                Id = updateUserRequestDto.Id,
                Name = updateUserRequestDto.Name,
                Email = updateUserRequestDto.Email,
                UserTypeId = updateUserRequestDto.UserTypeId,
                UpdatedAt = DateTime.UtcNow
            };
        }

        // Maps a User entity to a UserDto for returning user data.
        public UserDto? MapUserToUserDto(User user)
        {
            return new UserDto
            {
                Name = user.Name,
                Email = user.Email,
                UserTypeId = user.UserTypeId,
                CreatedAt = user.CreatedAt,
                UpdatedAt = user.UpdatedAt
            };
        }
    }
}
