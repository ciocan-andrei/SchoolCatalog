using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TeachersModel
    {
        public int TeacherId { get; set; }
        public String TeacherName { get; set; }
        public String TeacherSurname { get; set; }
        public int UserTypeId { get; set; }
    }
}
