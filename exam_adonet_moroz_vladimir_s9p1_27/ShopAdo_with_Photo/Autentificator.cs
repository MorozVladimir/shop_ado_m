using CodeFirstFromDatabase.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ShopAdo_with_Photo
{
    public static class Autentificator
    {
         static public int getRole()
        {
            FormLogin frmlogin = new FormLogin();
            var result = frmlogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(frmlogin.txtUserName.Text) || string.IsNullOrEmpty(frmlogin.txtUserName.Text))
                {
                    MessageBox.Show("Нет имя пользователя или пароля");
                    getRole();
                }
                using (ShopAdoContext context = new ShopAdoContext(ConString()))
                {
                    User user = context.Users.Where(u => u.UserName == frmlogin.txtUserName.Text
                        && u.UserPassword == frmlogin.txtPassford.Text).FirstOrDefault();
                    if (user != null)
                    {
                        UserInRole user_role = context.UserInRoles.Where(ur => ur.UserId == user.UserId).FirstOrDefault();
                        if (user_role != null) return user_role.RoleId;
                    }
                    else
                    {
                        MessageBox.Show("Пользователя с таким именем нет в базе");
                        getRole();
                    }
                }
            }
            return 0;
        }

        private static string ConString()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder
                (ConfigurationManager.ConnectionStrings["ShopAdoContext"].ConnectionString);
            sb.IntegratedSecurity = true;
            sb.InitialCatalog = "ShopAdo";
            return sb.ToString();
        }
    }
}
