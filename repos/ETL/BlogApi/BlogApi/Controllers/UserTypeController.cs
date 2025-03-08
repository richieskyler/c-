using BusinessLogicLayer.IMapperMethodsInterface;
using BusinessLogicLayer.IServices;
using DataAccessLayer.Models;
using DomainLayer.DTO.UserTypeDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTypeController : ControllerBase
    {
            public readonly IUserTypeService _usertypeService;
            public readonly IUserTypeMapper _usertypeMapper;

            public UserTypeController(IUserTypeService usertypeService, IUserTypeMapper usertypeMapper)
            {
                _usertypeService = usertypeService;
                _usertypeMapper = usertypeMapper;
            }

            // Retrieves all UserTypets and returns them as a list.
            [HttpGet]
            public IActionResult GetUserType()
            {
                return Ok(_usertypeService.GetAllUserType());
            }

            // Retrieves a specific usertype by its ID and returns it as a UserTypeDto.
            [HttpGet]
            public IActionResult GetById(int id)
            {
                UserType? usertype = _usertypeService.GetUserType(id);

                if (usertype == null)
                {
                    return NotFound();
                }

                UserTypeDto? usertypeDto = _usertypeMapper.MapUserTypeToUserTypeDto(usertype);
                return Ok(usertype);
            }

            // Creates a new usertype using the provided CreateUserTypeRequestDto and returns the created usertype as a UserTypeDto.
            [HttpPost]
            public IActionResult CreateUserType(CreateUserTypeRequestDto createUserTypeRequestDto)
            {
                UserType mappedUserType = _usertypeMapper.MapCreateUserTypeRequesDtoUserType(createUserTypeRequestDto);
                UserType? createdUserType = _usertypeService.CreateUserType(mappedUserType, out string message);

                if (createdUserType == null)
                {
                    return BadRequest(message);
                }

                UserTypeDto? mappedUserTypeDto = _usertypeMapper.MapUserTypeToUserTypeDto(createdUserType);
                return Ok(mappedUserTypeDto);
            }

            // Updates an existing UserType using the provided UpdateUserTypeRequestDto and returns the updated usertype as a UserTypeDto.
            [HttpPost]
            public IActionResult UpdateUserType([FromBody] UpdateUserTypeRequestDto updateUserTypeRequestDto)
            {
                UserType mappedUserType = _usertypeMapper.MapUpdateUserTypeRequestDtoToUserType(updateUserTypeRequestDto);

                UserType? usertypeUpdated = _usertypeService.UpdateUserType(mappedUserType, out string message);

                if (usertypeUpdated is null)
                {
                    return BadRequest(message);
                }

                UserTypeDto? UpdatedUserTypeDto = _usertypeMapper.MapUserTypeToUserTypeDto(usertypeUpdated);

                return Ok(UpdatedUserTypeDto);
            }

            // Deletes a usertype using the provided DeleteUserTypeRequestDto and returns a boolean indicating success or failure.
            [HttpDelete]
            public IActionResult DeleteUserType([FromBody] DeleteUserTypeRequestDto deleteUserTypeRequestDto)
            {
                UserType mappedUserType = _usertypeMapper.MapDeleteUserTypeRequestDtoToUserType(deleteUserTypeRequestDto);

                bool usertypeDeleted = _usertypeService.DeleteUserType(mappedUserType.Id, out string message);

                return Ok(usertypeDeleted);
            }
    }
}
