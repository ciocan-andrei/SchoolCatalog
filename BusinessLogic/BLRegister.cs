using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLRegister
    {
        public BLRegister()
        {

        }
        public string Base64Encode(string pass)
        {
            var passBytes = Encoding.UTF8.GetBytes(pass);
            return Convert.ToBase64String(passBytes);
        }
        public void Registration(string name, string surname, string password)
        {
            DARegister da = new DARegister();
            string encodedPass = Base64Encode(password);
            da.Registration(name, surname, encodedPass);
        }
        public String GetUsername(string name, string surname, string password)
        {
            DARegister da = new DARegister();
            string encodedPass = Base64Encode(password);
            DataTable dataTable = da.GetUsername(name, surname, encodedPass);

            String result = dataTable.Rows[0]["UserName"].ToString();
            return result;
        }
    }

    
}
