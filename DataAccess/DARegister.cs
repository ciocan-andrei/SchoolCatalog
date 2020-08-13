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
    public class DARegister
    {
        public DARegister()
        {

        }

        public void Registration (String name, String surname, String password)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("Registration");
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Name", name));
                command.Parameters.Add(new SqlParameter("@Surname", surname));
                command.Parameters.Add(new SqlParameter("@Password", password));

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source, "Exceptie", MessageBoxButtons.OK);
            }
        }

        public DataTable GetUsername(String name, String surname, String password)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("GetUsername");
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Name", name));
                command.Parameters.Add(new SqlParameter("@Surname", surname));
                command.Parameters.Add(new SqlParameter("@Password", password));

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

