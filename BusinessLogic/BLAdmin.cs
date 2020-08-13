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
    public class BLAdmin
    {
        public BLAdmin()
        {

        }
        public DataTable GetInactiveExternals()
        {
            DAAdmin da = new DAAdmin();
            return da.GetInactiveExternals();
        }
        public void SetUserActive(int userId)
        {
            DAAdmin da = new DAAdmin();
            da.SetUserActive(userId);
        }
        public void DenyUser(int userId, int externalId)
        {
            DAAdmin da = new DAAdmin();
            da.DenyUser(userId, externalId);
        }
        public DataTable GetRequests()
        {
            DAAdmin da = new DAAdmin();
            return da.GetRequests();
        }
        public void AcceptRequest(int externalId, int studentId)
        {
            DAAdmin da = new DAAdmin();
            da.AcceptRequest(externalId, studentId);
        }
        public void DenyRequest(int externalId, int studentId)
        {
            DAAdmin da = new DAAdmin();
            da.DenyRequest(externalId, studentId);
        }
        public DataTable GetAccounts()
        {
            DAAdmin da = new DAAdmin();
            return da.GetAccounts();
        }
        public DataTable GetAccounts(string name)
        {
            DAAdmin da = new DAAdmin();
            return da.GetAccounts(name);
        }
        public void UpdateAccount(int userId, bool isActive)
        {
            DAAdmin da = new DAAdmin();
            da.UpdateAccount(userId, isActive);
        }
        public List<StudentsModel> GetStudents(String studentName, String studentSurname, String studyGroup)
        {
            DAAdmin da = new DAAdmin();
            DataTable tableStudents = da.GetStudents(studentName, studentSurname, studyGroup);

            List<StudentsModel> studentsList = new List<StudentsModel>();
            for (int i = 0; i < tableStudents.Rows.Count; i++)
            {
                StudentsModel studentsModel = new StudentsModel();
                studentsModel.StudentId = Convert.ToInt32(tableStudents.Rows[i]["StudentId"]);
                studentsModel.StudentName = tableStudents.Rows[i]["StudentName"].ToString();
                studentsModel.StudentSurname = tableStudents.Rows[i]["StudentSurname"].ToString();
                studentsModel.StudyGroup = tableStudents.Rows[i]["StudyGroup"].ToString();
                studentsModel.StudySet = tableStudents.Rows[i]["StudySet"].ToString();
                studentsModel.StudyYear = Convert.ToInt32(tableStudents.Rows[i]["StudyYear"]);
                studentsList.Add(studentsModel);
            }
            return studentsList;
        }
        public void UpdateStudent(int studentId, String name, String surname, int year, String group, String set)
        {
            DAAdmin da = new DAAdmin();
            da.UpdateStudent(studentId, name, surname, year, group, set);
        }
        public DataTable GetTeachers(String name, String surname, String dept)
        {
            DAAdmin da = new DAAdmin();
            return da.GetTeachers(name, surname, dept);
        }
        public void UpdateTeacher(int teacherId, String name, String surname, String dept)
        {
            DAAdmin da = new DAAdmin();
            da.UpdateTeacher(teacherId, name, surname, dept);
        }
        public DataTable GetCourses(int teacherId)
        {
            DAAdmin da = new DAAdmin();
            return da.GetCourses(teacherId);
        }
        public DataTable GetListOfCourses(int teacherId)
        {
            DAAdmin da = new DAAdmin();
            return da.GetListOfCourses(teacherId);
        }
        public void AddTeacherCourse(int teacherId, int courseId, String set)
        {
            DAAdmin da = new DAAdmin();
            da.AddTeacherCourse(teacherId, courseId, set);
        }
        public void DeleteTeacherCourse(int teacherId, int courseId)
        {
            DAAdmin da = new DAAdmin();
            da.DeleteTeacherCourse(teacherId, courseId);
        }
    }
}
