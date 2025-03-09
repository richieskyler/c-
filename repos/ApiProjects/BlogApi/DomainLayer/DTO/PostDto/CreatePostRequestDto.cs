﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DomainLayer.DTO.PostDto
{
    public class CreatePostRequestDto
    {
        public string? Content { get; set; }

        
        // Foreign key reference, but hidden from serialization
        [JsonIgnore] // This prevents it from showing in Swagger and responses
        public Category? Category { get; set; }
        // Foreign key property - stores the ID value of the related Category
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }


        // Foreign key property - stores the ID value of the related Category
        [ForeignKey("UserTypeId")]
        // Foreign key reference, but hidden from serialization
        [JsonIgnore] // This prevents it from showing in Swagger and responses
        public UserType? UserType { get; set; }
        public int UserTypeId { get; set; }


        // Foreign key property - stores the ID value of the related Category
        [ForeignKey("UserId")]
        // Foreign key reference, but hidden from serialization
        [JsonIgnore] // This prevents it from showing in Swagger and responses
        public User? User { get; set; }
        public int UserId { get; set; }
    }
}
