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
    public class CommentService : ICommentService
    {
        //Private variable that stores the ICommentRepository object
        public readonly ICommentRepository _commentRepository;

        //Constructor of the CommentService class
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public Comment? CreateComment(Comment comment, out string message)
        {
            if (string.IsNullOrWhiteSpace(comment.Content))
            {
                message = "Comment cannot be empty";
                return null;
            }

            _commentRepository.Create(comment);
            message = "Comment created";
            return comment;
            
        }

        public bool DeleteComment(int id, out string message)
        {
            if(id <= 0)
            {
                message = "Invalid";
                return false;
            }

            Comment? comment = _commentRepository.Get(id); 

            if(comment is null)
            {
                message = "Comment Id dosent exist";
                return false;
            }

            _commentRepository.Delete(comment);
            message = "Comment deleted";
            return true;

        }

        public List<Comment> GetAllComment()
        {
            return _commentRepository.Get();
        }

        public Comment? GetComment(int id)
        {
            if (id <= 0)
            {
                return null;
            }
            return _commentRepository.Get(id);
        }

        public Comment? UpdateComment(Comment comment, out string message)
        {
            if (comment.Id <= 0)
            {
                message = "Invalid Id";
                return null;
            }

            if (comment.PostId <= 0)
            {
                message = "Invalid post Id";
                return null;
            }

            if (comment.UserId <= 0)
            {
                message = "UserId is Invalid";
                return null;
            }

            Comment? updatedComment = _commentRepository.Update(comment);

            message = "Successfully Upated";
            return updatedComment;
        }
    }
}

