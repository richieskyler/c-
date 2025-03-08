using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Like : BaseModel
    {
        

        public Post? Post { get; set; }
        [ForeignKey("PostId")]
        public int PostId { get; set; }

        public User? User { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
    }
}
