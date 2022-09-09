using Entities.Enum;
using Entities.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser<string>
    {
        // User ko extra custom property haru add garna i.e HasCat
        public UserType UserType { get; set; }
        public string Fullname { get; set; }
        public int? SchoolId { get; set; }
        public School School { get; set; }
        public bool IsActive { get; set; }
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
        public ICollection<ApplicationRole> Roles { get; set; }
    }
}
