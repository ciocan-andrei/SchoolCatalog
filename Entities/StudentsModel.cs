using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StudentsModel
    {
        public int StudentId { get; set; }
        public String StudentName { get; set; }
        public String StudentSurname { get; set; }
        public int StudyYear { get; set; }
        public String StudyGroup { get; set; }
        public String StudySet { get; set; }
        public int UserTypeId { get; set; }
    }
}
