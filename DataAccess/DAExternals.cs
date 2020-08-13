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
    public class DAExternals
    {
        public DAExternals()
        {

        }
        public DataTable GetStudents(String studentName, String studyGroup, int externalId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT StudentId, StudentName + ' ' + StudentSurname + ', ' + StudyGroup + StudySet as StudentInfo FROM Students" +
                                      " WHERE (LOWER(StudentName) LIKE '%' + @StudentName + '%' OR LOWER(StudentSurname) LIKE '%' + @StudentName + '%')" +
                                      " AND StudyGroup LIKE '%' + @StudyGroup + '%'" +
                                      " AND StudentId not in (SELECT StudentId from ExternalsRequests where ExternalId = @ExternalId)" +
                                      " AND StudentId not in (SELECT StudentId from ExternalsStudents where ExternalId = @ExternalId)" +
                                      " ORDER BY StudentName asc, StudentSurname asc";

                SqlParameter parameterName = new SqlParameter();
                SqlParameter parameterGroup = new SqlParameter();
                SqlParameter parameterId = new SqlParameter();

                parameterName.ParameterName = "@StudentName";
                parameterName.DbType = System.Data.DbType.String;
                parameterName.Size = 256;
                parameterName.Direction = System.Data.ParameterDirection.Input;
                parameterName.Value = studentName;

                parameterGroup.ParameterName = "@StudyGroup";
                parameterGroup.DbType = System.Data.DbType.String;
                parameterGroup.Size = 256;
                parameterGroup.Direction = System.Data.ParameterDirection.Input;
                parameterGroup.Value = studyGroup;

                parameterId.ParameterName = "@ExternalId";
                parameterId.DbType = System.Data.DbType.Int32;
                parameterId.Size = 256;
                parameterId.Direction = System.Data.ParameterDirection.Input;
                parameterId.Value = externalId;

                command.Parameters.Add(parameterName);
                command.Parameters.Add(parameterGroup);
                command.Parameters.Add(parameterId);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }

            return dataTable;
        }

        public void InsertRequests(int externalId, int studentId, String reason)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("InsertRequests");
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ExternalId", externalId));
                command.Parameters.Add(new SqlParameter("@StudentId", studentId));
                command.Parameters.Add(new SqlParameter("@Reason", reason));

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }
        }

        public DataTable GetRequests(int externalId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT s.StudentName + ' ' + s.StudentSurname as StudentName, s.StudyGroup + s.StudySet as StudyGroup, er.Reason FROM ExternalsRequests er" +
                                      " JOIN Students s on s.StudentId = er.StudentId" +
                                      " WHERE er.ExternalId = @ExternalId";

                SqlParameter id = new SqlParameter();

                id.ParameterName = "@ExternalId";
                id.DbType = System.Data.DbType.Int32;
                id.Size = 256;
                id.Direction = System.Data.ParameterDirection.Input;
                id.Value = externalId;

                command.Parameters.Add(id);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }

            return dataTable;
        }
        public DataTable GetAcceptedRequests(int externalId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT s.StudentName + ' ' + s.StudentSurname as StudentName, s.StudyGroup + s.StudySet as StudyGroup FROM ExternalsStudents es" +
                                      " JOIN Students s on s.StudentId = es.StudentId" +
                                      " WHERE es.ExternalId = @ExternalId";

                SqlParameter id = new SqlParameter();

                id.ParameterName = "@ExternalId";
                id.DbType = System.Data.DbType.Int32;
                id.Size = 256;
                id.Direction = System.Data.ParameterDirection.Input;
                id.Value = externalId;

                command.Parameters.Add(id);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }

            return dataTable;
        }
        public DataTable GetStudents(int externalId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT s.StudentId, s.StudentName + ' ' + s.StudentSurname + ', ' + s.StudyGroup + s.StudySet as StudentInfo FROM ExternalsStudents es" +
                                      " JOIN Students s on s.StudentId = es.StudentId" +
                                      " WHERE es.ExternalId = @ExternalId";

                SqlParameter parameterId = new SqlParameter();

                parameterId.ParameterName = "@ExternalId";
                parameterId.DbType = System.Data.DbType.Int32;
                parameterId.Size = 256;
                parameterId.Direction = System.Data.ParameterDirection.Input;
                parameterId.Value = externalId;

                command.Parameters.Add(parameterId);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }

            return dataTable;
        }

        public DataTable GetCatalogInfoPerYear(int studentId, int studyYear)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("GetCatalogInfoPerYear");
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@StudentId", studentId));
                command.Parameters.Add(new SqlParameter("@StudyYear", studyYear));

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

        public int GetYear(int studentId)
        {
            int studentYear = -1;
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT StudyYear from Students where StudentId = @StudentId";

                SqlParameter parameterId = new SqlParameter();

                parameterId.ParameterName = "@StudentId";
                parameterId.DbType = System.Data.DbType.Int32;
                parameterId.Size = 256;
                parameterId.Direction = System.Data.ParameterDirection.Input;
                parameterId.Value = studentId;

                command.Parameters.Add(parameterId);

                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    studentYear = sqlDataReader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }
            return studentYear;
        }
    }
}
