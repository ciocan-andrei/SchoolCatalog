using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLStudents
    {
        public BLStudents()
        {

        }
        public DataTable GetCatalogInfoS1(int studentId, int studyYear)
        {
            DAStudents da = new DAStudents();
            DataTable catalogTable = da.GetCatalogInfo(studentId, studyYear, 1);

            return catalogTable;
        }
        public DataTable GetCatalogInfoS2(int studentId, int studyYear)
        {
            DAStudents da = new DAStudents();
            DataTable catalogTable = da.GetCatalogInfo(studentId, studyYear, 2);

            return catalogTable;
        }
    }

}
