using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public int CountLikes { get; set; }
        public int CountComment { get; set; }

        //Navigation
        public Category Category { get; set; }
        [ForeignKey("PostCategoryId")]
        public string PostCategoryId { get; set; }

        public Author Author { get; set; }
        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
    }
}
