using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CoursesModel
    {
        public int CourseId { get; set; }
        public String CourseName { get; set; }
        public String CourseShortName { get; set; }
        public int Semester { get; set; }
        public int StudyYear { get; set; }

    }
}
