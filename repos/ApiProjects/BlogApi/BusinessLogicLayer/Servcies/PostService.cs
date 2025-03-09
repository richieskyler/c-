using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IServices;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Servcies
{
    public class PostService : IPostService
    {
        //Private variable that stores the IPostRepository object
        public readonly IPostRepository _postRepository;

        //Constructor of the PostService class
        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public Post? CreatePost(Post post, out string message)
        {
            if (string.IsNullOrWhiteSpace(post.Content))
            {
                message = "Post content cannot be empty";
                return null;
            }

            if(post.UserId <= 0)
            {
                message = "Invalid userId";
                return null;
            }

            //this condition can be removed but for data analytics purpose i want user to always specify the categoryId (so my Id can't be zero)
            if(post.CategoryId <= 0)
            {
                message = "Invalid categoryId";
                return null;
            }

            _postRepository.Create(post);
            message = "Post created";
            return post;
        }

        public bool DeletePost(int id, out string message)
        {
            if (id <= 0)
            {
                message = "Invalid Id";
                return false;
            }

            Post? post = _postRepository.Get(id);

            if (post is null)
            {
                message = "Id cannot be found";
                return false;
            }

            _postRepository.Delete(post);
            message = "Post Deleted Successfully";
            return true;
        }

        public List<Post> GetAllPost()
        {
            return _postRepository.Get();
        }

        public Post? GetPost(int id)
        {
            if (id <= 0)
            {
                return null;
            }
            return _postRepository.Get(id);
        }

        public Post? UpdatePost(Post post, out string message)
        {
            if (post.Id <= 0)
            {
                message = "Invalid Id";
                return null;
            }

            if (string.IsNullOrWhiteSpace(post.Content))
            {
                message = "Content is required";
                return null;
            }

            if (post.CategoryId <= 0)
            {
                message = "Ivalid CategoryId";
                return null;
            }

            Post? updatedPost = _postRepository.Update(post);

            message = "Successfully Upated";
            return updatedPost;
        }
    }
}
