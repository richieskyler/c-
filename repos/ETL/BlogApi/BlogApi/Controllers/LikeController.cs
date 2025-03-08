using BusinessLogicLayer.IMapperMethodsInterface;
using BusinessLogicLayer.IServices;
using DataAccessLayer.Models;
using DomainLayer.DTO.LikeDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LikeController : ControllerBase
    {   
            public readonly ILikeService _likeService;
            public readonly ILikeMapper _likeMapper;

            public LikeController(ILikeService likeService, ILikeMapper likeMapper)
            {
                _likeService = likeService;
                _likeMapper = likeMapper;
            }

            // Retrieves all Likes and returns them as a list.
            [HttpGet]
            public IActionResult GetLike()
            {
                return Ok(_likeService.GetAllLike());
            }

            // Retrieves a specific like by its ID and returns it as a LikeDto.
            [HttpGet]
            public IActionResult GetById(int id)
            {
                Like? like = _likeService.GetLike(id);

                if (like == null)
                {
                    return NotFound();
                }

                LikeDto? likeDto = _likeMapper.MapLikeToLikeDto(like);
                return Ok(like);
            }

            // Creates a new like using the provided CreateLikeRequestDto and returns the created like as a LikeDto.
            [HttpPost]
            public IActionResult CreateLike(CreateLikeRequestDto createLikeRequestDto)
            {
                Like mappedLike = _likeMapper.MapCreateLikeRequesDtoLike(createLikeRequestDto);
                Like? createdLike = _likeService.CreateLike(mappedLike, out string message);

                if (createdLike == null)
                {
                    return BadRequest(message);
                }

                LikeDto? mappedLikeDto = _likeMapper.MapLikeToLikeDto(createdLike);
                return Ok(mappedLikeDto);
            }



            // Deletes a like using the provided DeleteLikeRequestDto and returns a boolean indicating success or failure.
            [HttpDelete]
            public IActionResult DeleteLike([FromBody] DeleteLikeRequestDto deleteLikeRequestDto)
            {
                Like mappedLike = _likeMapper.MapDeleteLikeRequestDtoToLike(deleteLikeRequestDto);

                bool likeDeleted = _likeService.DeleteLike(mappedLike.Id, out string message);

                return Ok(likeDeleted);
            }
        
    }
}
