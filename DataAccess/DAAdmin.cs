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
    public class DAAdmin
    {
        public DAAdmin()
        {

        }

        public DataTable GetInactiveExternals()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT u.UserId, u.ExternalId, u.UserName, e.ExternalName + ' ' + e.ExternalSurname as ExternalName, convert(varchar, u.RegisterDate, 104) RegisterDate FROM Users u" +
                                      " JOIN Externals e on e.ExternalId = u.ExternalId and e.UserTypeId = u.UserTypeId" +
                                      " where u.IsActive = 0 and u.UserTypeId = 2 order by u.UserId desc";

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

        public void SetUserActive(int userId)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE Users set IsActive = 1 where UserId = @UserId";

                SqlParameter parameterId = new SqlParameter();

                parameterId.ParameterName = "@UserId";
                parameterId.DbType = System.Data.DbType.Int32;
                parameterId.Size = 256;
                parameterId.Direction = System.Data.ParameterDirection.Input;
                parameterId.Value = userId;

                command.Parameters.Add(parameterId);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }
        }
        public void DenyUser(int userId, int externalId)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE FROM Users WHERE UserId = @UserId and ExternalId = @ExternalId\n"+
                                      "DELETE FROM Externals WHERE ExternalId = @ExternalId";

                SqlParameter parameterId = new SqlParameter();
                SqlParameter parameterExtId = new SqlParameter();

                parameterId.ParameterName = "@UserId";
                parameterId.DbType = System.Data.DbType.Int32;
                parameterId.Size = 256;
                parameterId.Direction = System.Data.ParameterDirection.Input;
                parameterId.Value = userId;

                parameterExtId.ParameterName = "@ExternalId";
                parameterExtId.DbType = System.Data.DbType.Int32;
                parameterExtId.Size = 256;
                parameterExtId.Direction = System.Data.ParameterDirection.Input;
                parameterExtId.Value = externalId;

                command.Parameters.Add(parameterId);
                command.Parameters.Add(parameterExtId);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }
        }
        public DataTable GetRequests()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT er.ExternalId, er.StudentId, e.ExternalName + ' ' + e.ExternalSurname as ExternalName, s.StudentName + ' ' + s.StudentSurname as StudentName, s.StudyGroup + s.StudySet as StudyGroup, er.Reason FROM ExternalsRequests er" +
                                      " JOIN Students s on s.StudentId = er.StudentId" + 
                                      " JOIN Externals e on e.ExternalId = er.ExternalId";

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
        public void AcceptRequest(int externalId, int studentId)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO ExternalsStudents VALUES (@ExternalId, @StudentId)\n" +
                                      "DELETE FROM ExternalsRequests where ExternalId = @ExternalId and StudentId = @StudentId";

                SqlParameter parameterExtId = new SqlParameter();
                SqlParameter parameterStdId = new SqlParameter();

                parameterExtId.ParameterName = "@ExternalId";
                parameterExtId.DbType = System.Data.DbType.Int32;
                parameterExtId.Size = 256;
                parameterExtId.Direction = System.Data.ParameterDirection.Input;
                parameterExtId.Value = externalId;

                parameterStdId.ParameterName = "@StudentId";
                parameterStdId.DbType = System.Data.DbType.Int32;
                parameterStdId.Size = 256;
                parameterStdId.Direction = System.Data.ParameterDirection.Input;
                parameterStdId.Value = studentId;

                command.Parameters.Add(parameterExtId);
                command.Parameters.Add(parameterStdId);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }
        }
        public void DenyRequest(int externalId, int studentId)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE FROM ExternalsRequests where ExternalId = @ExternalId and StudentId = @StudentId";

                SqlParameter parameterExtId = new SqlParameter();
                SqlParameter parameterStdId = new SqlParameter();

                parameterExtId.ParameterName = "@ExternalId";
                parameterExtId.DbType = System.Data.DbType.Int32;
                parameterExtId.Size = 256;
                parameterExtId.Direction = System.Data.ParameterDirection.Input;
                parameterExtId.Value = externalId;

                parameterStdId.ParameterName = "@StudentId";
                parameterStdId.DbType = System.Data.DbType.Int32;
                parameterStdId.Size = 256;
                parameterStdId.Direction = System.Data.ParameterDirection.Input;
                parameterStdId.Value = studentId;

                command.Parameters.Add(parameterExtId);
                command.Parameters.Add(parameterStdId);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }
        }
        public DataTable GetAccounts()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT u.UserId, u.UserName," +
                                      " case when u.UserTypeId = 0 then t.TeacherName + ' ' + t.TeacherSurname" +
                                      " when u.UserTypeId = 1 then s.StudentName + ' ' + s.StudentSurname" +
                                      " when u.UserTypeId = 2 then e.ExternalName + ' ' + e.ExternalSurname" +
                                      " end as Name," +
                                      " ut.UserTypeName, u.IsActive" +
                                      " FROM Users u" +
                                      " JOIN UserTypes ut on ut.UserTypeId = u.UserTypeId" +
                                      " LEFT JOIN Teachers t on t.TeacherId = u.TeacherId and t.UserTypeId = u.UserTypeId" +
                                      " LEFT JOIN Students s on s.StudentId = u.StudentId and s.UserTypeId = u.UserTypeId" +
                                      " LEFT JOIN Externals e on e.ExternalId = u.ExternalId and e.UserTypeId = u.UserTypeId" +
                                      " WHERE u.UserTypeId <> 3";

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
        public DataTable GetAccounts(string name)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                //am folosit CTE pt ca where se executa inainte de select si nu putea filtra in acelasi timp pe nume + prenume
                command.CommandText = "with UsersNow as ( SELECT u.UserId, u.UserName," +
                                      " case when u.UserTypeId = 0 then t.TeacherName + ' ' + t.TeacherSurname" +
                                      " when u.UserTypeId = 1 then s.StudentName + ' ' + s.StudentSurname" +
                                      " when u.UserTypeId = 2 then e.ExternalName + ' ' + e.ExternalSurname" +
                                      " end as Name," +
                                      " ut.UserTypeName, u.IsActive" +
                                      " FROM Users u" +
                                      " JOIN UserTypes ut on ut.UserTypeId = u.UserTypeId" +
                                      " LEFT JOIN Teachers t on t.TeacherId = u.TeacherId and t.UserTypeId = u.UserTypeId" +
                                      " LEFT JOIN Students s on s.StudentId = u.StudentId and s.UserTypeId = u.UserTypeId" +
                                      " LEFT JOIN Externals e on e.ExternalId = u.ExternalId and e.UserTypeId = u.UserTypeId" +
                                      " WHERE u.UserTypeId <> 3 ) select UserId, UserName, Name, UserTypeName, IsActive from UsersNow where Name like '%' + @Name + '%'";

                SqlParameter parameterName = new SqlParameter();

                parameterName.ParameterName = "@Name";
                parameterName.DbType = System.Data.DbType.String;
                parameterName.Size = 256;
                parameterName.Direction = System.Data.ParameterDirection.Input;
                parameterName.Value = name;

                command.Parameters.Add(parameterName);
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
        public void UpdateAccount(int userId, bool isActive)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                if (isActive == true)
                {
                    command.CommandText = "UPDATE Users set IsActive = 1 where UserId = @UserId"; 
                }
                else
                {
                    command.CommandText = "UPDATE Users set IsActive = 0 where UserId = @UserId";
                }

                SqlParameter parameterId = new SqlParameter();

                parameterId.ParameterName = "@UserId";
                parameterId.DbType = System.Data.DbType.Int32;
                parameterId.Size = 256;
                parameterId.Direction = System.Data.ParameterDirection.Input;
                parameterId.Value = userId;

                command.Parameters.Add(parameterId);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }
        }
        public DataTable GetStudents(String studentName, String studentSurname, String studyGroup)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT StudentId, StudentName, StudentSurname, StudyYear, StudyGroup, StudySet FROM Students" +
                                      " WHERE StudentName like '%' + @StudentName + '%' AND StudentSurname like '%' + @StudentSurname + '%' AND StudyGroup like '%' + @StudyGroup + '%'";

                SqlParameter parameterName = new SqlParameter();
                SqlParameter parameterSurname = new SqlParameter();
                SqlParameter parameterGroup = new SqlParameter();

                parameterName.ParameterName = "@StudentName";
                parameterName.DbType = System.Data.DbType.String;
                parameterName.Size = 256;
                parameterName.Direction = System.Data.ParameterDirection.Input;
                parameterName.Value = studentName;

                parameterSurname.ParameterName = "@StudentSurname";
                parameterSurname.DbType = System.Data.DbType.String;
                parameterSurname.Size = 256;
                parameterSurname.Direction = System.Data.ParameterDirection.Input;
                parameterSurname.Value = studentSurname;

                parameterGroup.ParameterName = "@StudyGroup";
                parameterGroup.DbType = System.Data.DbType.String;
                parameterGroup.Size = 256;
                parameterGroup.Direction = System.Data.ParameterDirection.Input;
                parameterGroup.Value = studyGroup;

                command.Parameters.Add(parameterName);
                command.Parameters.Add(parameterSurname);
                command.Parameters.Add(parameterGroup);
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
        public void UpdateStudent(int studentId, String name, String surname, int year, String group, String set)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE Students SET StudentName = @StudentName, StudentSurname = @StudentSurname, StudyYear = @StudyYear, StudyGroup = @StudyGroup, StudySet = @StudySet" +
                                      " WHERE StudentId = @StudentId";

                SqlParameter parameterId = new SqlParameter();
                SqlParameter parameterName = new SqlParameter();
                SqlParameter parameterSurname = new SqlParameter();
                SqlParameter parameterYear = new SqlParameter();
                SqlParameter parameterGroup = new SqlParameter();
                SqlParameter parameterSet = new SqlParameter();

                parameterId.ParameterName = "@StudentId";
                parameterId.DbType = System.Data.DbType.Int32;
                parameterId.Size = 256;
                parameterId.Direction = System.Data.ParameterDirection.Input;
                parameterId.Value = studentId;

                parameterName.ParameterName = "@StudentName";
                parameterName.DbType = System.Data.DbType.String;
                parameterName.Size = 256;
                parameterName.Direction = System.Data.ParameterDirection.Input;
                parameterName.Value = name;

                parameterSurname.ParameterName = "@StudentSurname";
                parameterSurname.DbType = System.Data.DbType.String;
                parameterSurname.Size = 256;
                parameterSurname.Direction = System.Data.ParameterDirection.Input;
                parameterSurname.Value = surname;

                parameterYear.ParameterName = "@StudyYear";
                parameterYear.DbType = System.Data.DbType.Int32;
                parameterYear.Size = 256;
                parameterYear.Direction = System.Data.ParameterDirection.Input;
                parameterYear.Value = year;

                parameterGroup.ParameterName = "@StudyGroup";
                parameterGroup.DbType = System.Data.DbType.String;
                parameterGroup.Size = 256;
                parameterGroup.Direction = System.Data.ParameterDirection.Input;
                parameterGroup.Value = group;

                parameterSet.ParameterName = "@StudySet";
                parameterSet.DbType = System.Data.DbType.String;
                parameterSet.Size = 256;
                parameterSet.Direction = System.Data.ParameterDirection.Input;
                parameterSet.Value = set;

                command.Parameters.Add(parameterId);
                command.Parameters.Add(parameterName);
                command.Parameters.Add(parameterSurname);
                command.Parameters.Add(parameterYear);
                command.Parameters.Add(parameterGroup);
                command.Parameters.Add(parameterSet);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }
        }
        public DataTable GetTeachers(String name, String surname, String dept)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT TeacherId, TeacherName, TeacherSurname, Department FROM Teachers" +
                                      " WHERE TeacherName like '%' + @TeacherName + '%' and TeacherSurname like '%' + @TeacherSurname + '%' and Department like '%' + @Department + '%'";

                SqlParameter parameterName = new SqlParameter();
                SqlParameter parameterSurname = new SqlParameter();
                SqlParameter parameterDept = new SqlParameter();

                parameterName.ParameterName = "@TeacherName";
                parameterName.DbType = System.Data.DbType.String;
                parameterName.Size = 256;
                parameterName.Direction = System.Data.ParameterDirection.Input;
                parameterName.Value = name;

                parameterSurname.ParameterName = "@TeacherSurname";
                parameterSurname.DbType = System.Data.DbType.String;
                parameterSurname.Size = 256;
                parameterSurname.Direction = System.Data.ParameterDirection.Input;
                parameterSurname.Value = surname;

                parameterDept.ParameterName = "@Department";
                parameterDept.DbType = System.Data.DbType.String;
                parameterDept.Size = 256;
                parameterDept.Direction = System.Data.ParameterDirection.Input;
                parameterDept.Value = dept;

                command.Parameters.Add(parameterName);
                command.Parameters.Add(parameterSurname);
                command.Parameters.Add(parameterDept);
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
        public void UpdateTeacher(int teacherId, String name, String surname, String dept)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE Teachers SET TeacherName = @TeacherName, TeacherSurname = @TeacherSurname, Department = @Department" +
                                      " WHERE TeacherId = @TeacherId";

                SqlParameter parameterId = new SqlParameter();
                SqlParameter parameterName = new SqlParameter();
                SqlParameter parameterSurname = new SqlParameter();
                SqlParameter parameterDept = new SqlParameter();

                parameterId.ParameterName = "@TeacherId";
                parameterId.DbType = System.Data.DbType.Int32;
                parameterId.Size = 256;
                parameterId.Direction = System.Data.ParameterDirection.Input;
                parameterId.Value = teacherId;

                parameterName.ParameterName = "@TeacherName";
                parameterName.DbType = System.Data.DbType.String;
                parameterName.Size = 256;
                parameterName.Direction = System.Data.ParameterDirection.Input;
                parameterName.Value = name;

                parameterSurname.ParameterName = "@TeacherSurname";
                parameterSurname.DbType = System.Data.DbType.String;
                parameterSurname.Size = 256;
                parameterSurname.Direction = System.Data.ParameterDirection.Input;
                parameterSurname.Value = surname;

                parameterDept.ParameterName = "@Department";
                parameterDept.DbType = System.Data.DbType.String;
                parameterDept.Size = 256;
                parameterDept.Direction = System.Data.ParameterDirection.Input;
                parameterDept.Value = dept;

                command.Parameters.Add(parameterId);
                command.Parameters.Add(parameterName);
                command.Parameters.Add(parameterSurname);
                command.Parameters.Add(parameterDept);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }
        }
        public DataTable GetCourses(int teacherId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT t.CourseId, c.CourseName, t.StudySet FROM TeachersXCoursesXStudySet t" +
                                      " JOIN Courses c on c.CourseId = t.CourseId WHERE t.TeacherId = @TeacherId";

                SqlParameter parameterId = new SqlParameter();

                parameterId.ParameterName = "@TeacherId";
                parameterId.DbType = System.Data.DbType.String;
                parameterId.Size = 256;
                parameterId.Direction = System.Data.ParameterDirection.Input;
                parameterId.Value = teacherId;


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
        public DataTable GetListOfCourses(int teacherId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT CourseId, CourseName FROM Courses WHERE CourseId not in (SELECT CourseId from TeachersXCoursesXStudySet WHERE TeacherId = @TeacherId) ORDER BY CourseName asc";

                SqlParameter parameterTchId = new SqlParameter();
                parameterTchId.ParameterName = "@TeacherId";
                parameterTchId.DbType = System.Data.DbType.Int32;
                parameterTchId.Size = 256;
                parameterTchId.Direction = System.Data.ParameterDirection.Input;
                parameterTchId.Value = teacherId;

                command.Parameters.Add(parameterTchId);

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
        public void AddTeacherCourse(int teacherId, int courseId, String set)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO TeachersXCoursesXStudySet VALUES (@TeacherId, @CourseId, @StudySet)";

                SqlParameter parameterTchId = new SqlParameter();
                SqlParameter parameterCrsId = new SqlParameter();
                SqlParameter parameterSet = new SqlParameter();

                parameterTchId.ParameterName = "@TeacherId";
                parameterTchId.DbType = System.Data.DbType.Int32;
                parameterTchId.Size = 256;
                parameterTchId.Direction = System.Data.ParameterDirection.Input;
                parameterTchId.Value = teacherId;

                parameterCrsId.ParameterName = "@CourseId";
                parameterCrsId.DbType = System.Data.DbType.Int32;
                parameterCrsId.Size = 256;
                parameterCrsId.Direction = System.Data.ParameterDirection.Input;
                parameterCrsId.Value = courseId;

                parameterSet.ParameterName = "@StudySet";
                parameterSet.DbType = System.Data.DbType.String;
                parameterSet.Size = 256;
                parameterSet.Direction = System.Data.ParameterDirection.Input;
                parameterSet.Value = set;

                command.Parameters.Add(parameterTchId);
                command.Parameters.Add(parameterCrsId);
                command.Parameters.Add(parameterSet);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }
        }
        public void DeleteTeacherCourse(int teacherId, int courseId)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE FROM TeachersXCoursesXStudySet WHERE TeacherId = @TeacherId AND CourseId = @CourseId";

                SqlParameter parameterTchId = new SqlParameter();
                SqlParameter parameterCrsId = new SqlParameter();

                parameterTchId.ParameterName = "@TeacherId";
                parameterTchId.DbType = System.Data.DbType.Int32;
                parameterTchId.Size = 256;
                parameterTchId.Direction = System.Data.ParameterDirection.Input;
                parameterTchId.Value = teacherId;

                parameterCrsId.ParameterName = "@CourseId";
                parameterCrsId.DbType = System.Data.DbType.Int32;
                parameterCrsId.Size = 256;
                parameterCrsId.Direction = System.Data.ParameterDirection.Input;
                parameterCrsId.Value = courseId;

                command.Parameters.Add(parameterTchId);
                command.Parameters.Add(parameterCrsId);
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
