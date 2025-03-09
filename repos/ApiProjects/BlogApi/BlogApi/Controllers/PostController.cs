using BusinessLogicLayer.IMapperMethodsInterface;
using BusinessLogicLayer.IServices;
using DataAccessLayer.Models;
using DomainLayer.DTO.PostDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        public readonly IPostService _postService;
        public readonly IPostMapper _postMapper;

        public PostController(IPostService postService, IPostMapper postMapper)
        {
            _postService = postService;
            _postMapper = postMapper;
        }

        // Retrieves all Postts and returns them as a list.
        [HttpGet]
        public IActionResult GetPost()
        {
            return Ok(_postService.GetAllPost());
        }

        // Retrieves a specific post by its ID and returns it as a PostDto.
        [HttpGet]
        public IActionResult GetById(int id)
        {
            Post? post = _postService.GetPost(id);

            if (post == null)
            {
                return NotFound();
            }

            PostDto? postDto = _postMapper.MapPostToPostDto(post);
            return Ok(post);
        }

        // Creates a new post using the provided CreatePostRequestDto and returns the created post as a PostDto.
        [HttpPost]
        public IActionResult CreatePost(CreatePostRequestDto createPostRequestDto)
        {
            Post mappedPost = _postMapper.MapCreatePostRequesDtoPost(createPostRequestDto);
            Post? createdPost = _postService.CreatePost(mappedPost, out string message);

            if (createdPost == null)
            {
                return BadRequest(message);
            }

            PostDto? mappedPostDto = _postMapper.MapPostToPostDto(createdPost);
            return Ok(mappedPostDto);
        }

        // Updates an existing Post using the provided UpdatePostRequestDto and returns the updated post as a PostDto.
        [HttpPost]
        public IActionResult UpdatePost([FromBody] UpdatePostRequestDto updatePostRequestDto)
        {
            Post mappedPost = _postMapper.MapUpdatePostRequestDtoToPost(updatePostRequestDto);

            Post? postUpdated = _postService.UpdatePost(mappedPost, out string message);

            if (postUpdated is null)
            {
                return BadRequest(message);
            }

            PostDto? UpdatedPostDto = _postMapper.MapPostToPostDto(postUpdated);

            return Ok(UpdatedPostDto);
        }

        // Deletes a post using the provided DeletePostRequestDto and returns a boolean indicating success or failure.
        [HttpDelete]
        public IActionResult DeletePost([FromBody] DeletePostRequestDto deletePostRequestDto)
        {
            Post mappedPost = _postMapper.MapDeletePostRequestDtoToPost(deletePostRequestDto);

            bool postDeleted = _postService.DeletePost(mappedPost.Id, out string message);

            return Ok(postDeleted);
        }
    }   
}
