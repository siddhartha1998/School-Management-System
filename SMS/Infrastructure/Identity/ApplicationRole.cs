using Entities.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class ApplicationRole : IdentityRole<string>
    {
        // add custom properties
        public RoleType RoleType { get; set; }
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
    }
}
