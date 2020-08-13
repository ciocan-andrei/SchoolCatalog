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
    public class BLExternals
    {
        public BLExternals()
        {

        }

        public DataTable GetStudents(String studentName, String studyGroup, int externalId)
        {
            DAExternals da = new DAExternals();
            DataTable tableStudents = da.GetStudents(studentName, studyGroup, externalId);
            return tableStudents;
        }
        public void InsertRequests(int externalId, int studentId, String reason)
        {
            DAExternals da = new DAExternals();
            da.InsertRequests(externalId, studentId, reason);
        }
        public DataTable GetRequests(int externalId)
        {
            DAExternals da = new DAExternals();
            DataTable tableRequests = da.GetRequests(externalId);
            return tableRequests;
        }
        public DataTable GetAcceptedRequests(int externalId)
        {
            DAExternals da = new DAExternals();
            DataTable tableRequests = da.GetAcceptedRequests(externalId);
            return tableRequests;
        }
        public DataTable GetStudents(int externalId)
        {
            DAExternals da = new DAExternals();
            DataTable tableStudents = da.GetStudents(externalId);
            return tableStudents;
        }
        public DataTable GetCatalogInfoPerYear(int studentId, int studyYear)
        {
            DAExternals da = new DAExternals();
            DataTable tableCatalog = da.GetCatalogInfoPerYear(studentId, studyYear);
            return tableCatalog;
        }
        public int GetYear(int studentId)
        {
            DAExternals da = new DAExternals();
            int studentYear = da.GetYear(studentId);
            return studentYear;
        }
    }
}
