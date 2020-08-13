using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CatalogInfoModel
    {
        public int EntryId { get; set; }
        public StudentsModel Student { get; set; }
        public CoursesModel Course { get; set; }
        public int PartialExam { get; set; }
        public int FinalExam { get; set; }
        public int Laboratory { get; set; }
        public int Seminary { get; set; }
        public int BonusPoints { get; set; }
        public int Total { get; set; }
        public String LastUpdate { get; set; }

    }
}
