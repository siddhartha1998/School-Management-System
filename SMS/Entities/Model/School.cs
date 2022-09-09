using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }

        public ICollection<Teacher> Teachers { get; private set; }
        public ICollection<Student> Students { get; private set; }

        public School()
        {
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }

    }
}
