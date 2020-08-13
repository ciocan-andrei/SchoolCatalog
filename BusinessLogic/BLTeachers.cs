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
    public class BLTeachers
    {
        public BLTeachers()
        {

        }

        public List<TeachersXCoursesXStudySetModel> GetTeacherCourses(int teacherId)
        {
            DATeachers da = new DATeachers();
            DataTable dt = da.GetTeacherCourses(teacherId);

            List<TeachersXCoursesXStudySetModel> list = new List<TeachersXCoursesXStudySetModel>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TeachersXCoursesXStudySetModel courses = new TeachersXCoursesXStudySetModel();
                courses.Courses = new CoursesModel
                {
                    CourseId = Convert.ToInt32(dt.Rows[i]["CourseId"]),
                    CourseName = dt.Rows[i]["CourseName"].ToString()
                };
                courses.Teachers = new TeachersModel
                {
                    TeacherId = Convert.ToInt32(dt.Rows[i]["TeacherId"]),
                    TeacherName = dt.Rows[i]["TeacherName"].ToString()
                };
                courses.StudySet = dt.Rows[i]["StudySet"].ToString();

                list.Add(courses);
            }
            return list;
        }

        public List<CatalogInfoModel> GetTeacherStudents(int courseId, String studySet)
        {
            DATeachers da = new DATeachers();
            DataTable dt = da.GetTeacherStudents(courseId, studySet);

            List<CatalogInfoModel> list = new List<CatalogInfoModel>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CatalogInfoModel catalogInfo = new CatalogInfoModel();
                catalogInfo.EntryId = Convert.ToInt32(dt.Rows[i]["EntryId"]);
                catalogInfo.Student = new StudentsModel
                {
                    StudentId = Convert.ToInt32(dt.Rows[i]["StudentId"]),
                    StudentName = dt.Rows[i]["StudentName"].ToString(),
                    StudyGroup = dt.Rows[i]["StudyGroup"].ToString()
                };
                catalogInfo.Laboratory = Convert.ToInt32(dt.Rows[i]["Laboratory"]);
                catalogInfo.Seminary = Convert.ToInt32(dt.Rows[i]["Seminary"]);
                catalogInfo.PartialExam = Convert.ToInt32(dt.Rows[i]["PartialExam"]);
                catalogInfo.FinalExam = Convert.ToInt32(dt.Rows[i]["FinalExam"]);
                catalogInfo.BonusPoints = Convert.ToInt32(dt.Rows[i]["BonusPoints"]);
                catalogInfo.Total = Convert.ToInt32(dt.Rows[i]["Total"]);
                catalogInfo.LastUpdate = dt.Rows[i]["LastUpdate"].ToString();

                list.Add(catalogInfo);
            }
            return list;
        }

        public List<CatalogInfoModel> GetTeacherStudents(int courseId, String studySet, String studentName, String studyGroup)
        {
            DATeachers da = new DATeachers();
            DataTable dt = da.GetTeacherStudents(courseId, studySet, studentName, studyGroup);

            List<CatalogInfoModel> list = new List<CatalogInfoModel>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CatalogInfoModel catalogInfo = new CatalogInfoModel();
                catalogInfo.EntryId = Convert.ToInt32(dt.Rows[i]["EntryId"]);
                catalogInfo.Student = new StudentsModel
                {
                    StudentId = Convert.ToInt32(dt.Rows[i]["StudentId"]),
                    StudentName = dt.Rows[i]["StudentName"].ToString(),
                    StudyGroup = dt.Rows[i]["StudyGroup"].ToString()
                };
                catalogInfo.Laboratory = Convert.ToInt32(dt.Rows[i]["Laboratory"]);
                catalogInfo.Seminary = Convert.ToInt32(dt.Rows[i]["Seminary"]);
                catalogInfo.PartialExam = Convert.ToInt32(dt.Rows[i]["PartialExam"]);
                catalogInfo.FinalExam = Convert.ToInt32(dt.Rows[i]["FinalExam"]);
                catalogInfo.BonusPoints = Convert.ToInt32(dt.Rows[i]["BonusPoints"]);
                catalogInfo.Total = Convert.ToInt32(dt.Rows[i]["Total"]);
                catalogInfo.LastUpdate = dt.Rows[i]["LastUpdate"].ToString();

                list.Add(catalogInfo);
            }
            return list;
        }

        public void UpdateCatalogInfo(int entryId, int partialExam, int finalExam, int laboratory, int seminary, int bonusPoints)
        {
            DATeachers da = new DATeachers();
            da.UpdateCatalogInfo(entryId, partialExam, finalExam, laboratory, seminary, bonusPoints);
        }

    }
}
