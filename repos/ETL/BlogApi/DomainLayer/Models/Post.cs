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
       
        public string Content { get; set; }
        

        // Navigation property - gives you access to the full Category object
        public Category Category { get; set; }

        // Foreign key property - stores the ID value of the related Category
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }


        // Navigation property - gives you access to the full Category object
        public User User { get; set; }

        // Foreign key property - stores the ID value of the related Category
        [ForeignKey("UserId")]
        public int UserId { get; set; }



        
    }
}
