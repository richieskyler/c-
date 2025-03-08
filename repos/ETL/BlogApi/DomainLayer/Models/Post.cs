using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Post : BaseModel
    {
       
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
