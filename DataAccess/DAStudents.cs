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
    public class DAStudents
    {
        public DAStudents()
        {

        }

        public DataTable GetCatalogInfo(int studentId, int studyYear, int semester)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("GetCatalogInfo");
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@StudentId", studentId));
                command.Parameters.Add(new SqlParameter("@StudyYear", studyYear));
                command.Parameters.Add(new SqlParameter("@Semester", semester));

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
    }
}
