using BusinessLogicLayer.IMapperMethodsInterface;
using BusinessLogicLayer.IServices;
using DataAccessLayer.Models;
using DomainLayer.DTO.UserDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]/[option]")]
    [ApiController]
    public class UserController : ControllerBase
    {
            public readonly IUserService _userService;
            public readonly IUserMapper _userMapper;

            public UserController(IUserService userService, IUserMapper userMapper)
            {
                _userService = userService;
                _userMapper = userMapper;
            }

            // Retrieves all Userts and returns them as a list.
            [HttpGet]
            public IActionResult GetUser()
            {
                return Ok(_userService.GetAllUser());
            }

            // Retrieves a specific user by its ID and returns it as a UserDto.
            [HttpGet]
            public IActionResult GetById(int id)
            {
                User? user = _userService.GetUser(id);

                if (user == null)
                {
                    return NotFound();
                }

                UserDto? userDto = _userMapper.MapUserToUserDto(user);
                return Ok(user);
            }

            // Creates a new user using the provided CreateUserRequestDto and returns the created user as a UserDto.
            [HttpPost]
            public IActionResult CreateUser(CreateUserRequestDto createUserRequestDto)
            {
                User mappedUser = _userMapper.MapCreateUserRequesDtoUser(createUserRequestDto);
                User? createdUser = _userService.CreateUser(mappedUser, out string message);

                if (createdUser == null)
                {
                    return BadRequest(message);
                }

                UserDto? mappedUserDto = _userMapper.MapUserToUserDto(createdUser);
                return Ok(mappedUserDto);
            }

            // Updates an existing User using the provided UpdateUserRequestDto and returns the updated user as a UserDto.
            [HttpPost]
            public IActionResult UpdateUser([FromBody] UpdateUserRequestDto updateUserRequestDto)
            {
                User mappedUser = _userMapper.MapUpdateUserRequestDtoToUser(updateUserRequestDto);

                User? userUpdated = _userService.UpdateUser(mappedUser, out string message);

                if (userUpdated is null)
                {
                    return BadRequest(message);
                }

                UserDto? UpdatedUserDto = _userMapper.MapUserToUserDto(userUpdated);

                return Ok(UpdatedUserDto);
            }

            // Deletes a user using the provided DeleteUserRequestDto and returns a boolean indicating success or failure.
            [HttpDelete]
            public IActionResult DeleteUser([FromBody] DeleteUserRequestDto deleteUserRequestDto)
            {
                User mappedUser = _userMapper.MapDeleteUserRequestDtoToUser(deleteUserRequestDto);

                bool userDeleted = _userService.DeleteUser(mappedUser.Id, out string message);

                return Ok(userDeleted);
            }
    }
}
