
using Entities.Enum;

namespace Entities.Model
{
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public UserType UserType { get; set; }
        public int? CoOpId { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string[] Roles { get; set; }
    }
    public class Role
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public List<User> User { get; set; }
    }
}