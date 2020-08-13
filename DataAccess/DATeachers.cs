using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess
{
    public class DATeachers
    {
        public DATeachers()
        {

        }

        public DataTable GetTeacherCourses(int teacherId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("GetTeacherCourses");
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@TeacherId", teacherId));


                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }

            return dataTable;
        }

        public DataTable GetTeacherStudents(int courseId, String studySet)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("GetTeacherStudents");
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CourseId", courseId));
                command.Parameters.Add(new SqlParameter("@StudySet", studySet));

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }

            return dataTable;
        }

        public DataTable GetTeacherStudents(int courseId, String studySet, String studentName, String studyGroup)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("GetTeacherStudents");
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CourseId", courseId));
                command.Parameters.Add(new SqlParameter("@StudySet", studySet));
                command.Parameters.Add(new SqlParameter("@StudentName", studentName));
                command.Parameters.Add(new SqlParameter("@StudyGroup", studyGroup));

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }

            return dataTable;
        }

        public void UpdateCatalogInfo(int entryId, int partialExam, int finalExam, int laboratory, int seminary, int bonusPoints)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("UpdateCatalogInfo");
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@EntryId", entryId));
                command.Parameters.Add(new SqlParameter("@PartialExam", partialExam));
                command.Parameters.Add(new SqlParameter("@FinalExam", finalExam));
                command.Parameters.Add(new SqlParameter("@Laboratory", laboratory));
                command.Parameters.Add(new SqlParameter("@Seminary", seminary));
                command.Parameters.Add(new SqlParameter("@BonusPoints", bonusPoints));

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }
        }

    }
}
