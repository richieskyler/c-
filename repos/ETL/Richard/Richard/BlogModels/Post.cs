using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.BlogModels
{
    class Post
    {
        public int Id { get; set; }

        public string Details { get; set; }

        public int likes { get; set; }

        public int comments { get; set; }


        //Navigation
        public PostCategory PostCategory { get; set; }
        [ForeignKey("PostCategoryId")]
        public string PostCategoryId { get; set; }

        public Author Author { get; set; }
        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }

    }
}
