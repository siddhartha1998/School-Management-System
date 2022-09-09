using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.CreateUser
{
    public class CreateApplicationUserCommand
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int? SchoolId { get; set; }
        public bool IsActive { get; set; }
    }
}
