using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DomainLayer.DTO.UserDto
{
    public class UserDto
    {

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }

        // Foreign key property - stores the ID value of the related Category
        [ForeignKey("UserTypeId")]
        // Navigation property - gives you access to the full Category object
        [JsonIgnore]
        public UserType? UserType { get; set; }
        public int UserTypeId { get; set; }
    }
}
