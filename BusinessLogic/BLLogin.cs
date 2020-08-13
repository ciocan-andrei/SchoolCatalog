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
    public class BLLogin
    {
        public BLLogin()
        {

        }

        public string Base64Encode(string pass)
        {
            var passBytes = Encoding.UTF8.GetBytes(pass);
            return Convert.ToBase64String(passBytes);
        }

        public UserModel CheckUser(string userName, string password, out int status, out Boolean isActive)
        {
            isActive = false;
            status = 2;
            UserModel userModel = new UserModel();
            DALogin da = new DALogin();
            DataTable usersTable = da.CheckUser(userName);
            if (usersTable.Rows.Count == 0)
                status = 1; //wrong user
            else
            {
                for (int i = 0; i < usersTable.Rows.Count; i++)
                {
                    if (Base64Encode(password) == usersTable.Rows[i]["UserPassword"].ToString())
                    {
                        userModel.UserId = Convert.ToInt32(usersTable.Rows[i]["UserId"]);
                        userModel.UserName = usersTable.Rows[i]["UserName"].ToString();
                        userModel.UserPassword = usersTable.Rows[i]["UserPassword"].ToString();
                        userModel.IsActive = Convert.ToBoolean(usersTable.Rows[i]["IsActive"]);
                        userModel.UserTypeId = Convert.ToInt32(usersTable.Rows[i]["UserTypeId"]);
                        userModel.UserInfoId = Convert.ToInt32(usersTable.Rows[i]["UserInfoId"]);
                        isActive = userModel.IsActive;
                    }
                    else
                    {
                        status = 0; //wrong pass
                    }
                }
            }

            return userModel;
        }
    }
}
