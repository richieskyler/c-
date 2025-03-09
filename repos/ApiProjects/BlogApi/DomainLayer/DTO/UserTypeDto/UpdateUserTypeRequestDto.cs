using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO.UserTypeDto
{
    public class UpdateUserTypeRequestDto
    {
        public int Id { get; set; }
        public string? UserTypeName { get; set; }
    }
}
