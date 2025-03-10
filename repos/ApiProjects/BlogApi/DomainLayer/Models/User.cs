using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class User : BaseModel
    {
        
        public string? Name { get; set; }
        public string? Email { get; set; }

       

        // Foreign key property - stores the ID value of the related Category
        [ForeignKey("UserTypeId")]
        // Navigation property - gives you access to the full Category object
        public UserType? UserType { get; set; }
        public int UserTypeId { get; set; }

    }
}
