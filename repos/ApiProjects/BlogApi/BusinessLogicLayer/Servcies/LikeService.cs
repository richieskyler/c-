using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IServices;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Servcies
{
    public class LikeService : ILikeService
    {
        //Private variable that stores the ILikeRepository object
        public readonly ILikeRepository _likeRepository;

        //Constructor of the LikeService class
        public LikeService(ILikeRepository likeRepository)
        {
            _likeRepository = likeRepository;
        }

        public Like? CreateLike(Like like, out string message)
        {
            if (like.UserId <= 0)
            {
                message = "LikeId cannot be null";
                return null;
            }

            if(like.PostId <= 0)
            {
                message = "PostId cannot be empty";
                return null;
            }

            _likeRepository.Create(like);
            message = "like created succefully";
            return like;
        }

        public bool DeleteLike(int id, out string message)
        {
            if(id <= 0)
            {
                message = "Invalid Id";
                return false;
            }

            Like? like = _likeRepository.Get(id);

            if (like is null)
            {
                message = "Id cannot be found";
                return false;
            }

            _likeRepository.Delete(like);
            message = "Liked Deleted Successfully";
            return true;
        }

        public List<Like> GetAllLike()
        {
            return _likeRepository.Get();
        }

        public Like? GetLike(int id)
        {
            if (id <= 0)
            {
                return null;
            }
            return _likeRepository.Get(id);
        }

        public Like? UpdateLike(Like like, out string message)
        {
            if (like.Id <= 0)
            {
                message = "Invalid Id";
                return null;
            }

            if (like.PostId <= 0)
            {
                message = "Invalid PostId";
                return null;
            }

            if (like.UserId <= 0)
            {
                message = "Invalid UserId";
                return null;
            }

            Like? updatedLike = _likeRepository.Update(like);

            message = "Successfully Upated";
            return updatedLike;
        }
    }
}
