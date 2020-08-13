using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TeachersXCoursesXStudySetModel
    {
        public TeachersModel Teachers { get; set; }
        public CoursesModel Courses { get; set; }
        public String StudySet { get; set; }
    }
}
