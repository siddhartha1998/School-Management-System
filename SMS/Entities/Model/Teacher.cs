using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TemporaryAddress { get; set; }
        public string PermanentAddress { get; set; }
        public double MobileNumber { get; set; }
        public string Email { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
    }
}
