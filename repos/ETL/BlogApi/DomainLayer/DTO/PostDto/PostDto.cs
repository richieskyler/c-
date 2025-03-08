using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DomainLayer.DTO.PostDto
{
    public class PostDto
    {

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Content { get; set; }

        // Foreign key property - stores the ID value of the related Category
        public Category? Category { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }


        // Foreign key property - stores the ID value of the related Category
        [ForeignKey("UserId")]
        public User? User { get; set; }
        public int UserId { get; set; }
    }
}
