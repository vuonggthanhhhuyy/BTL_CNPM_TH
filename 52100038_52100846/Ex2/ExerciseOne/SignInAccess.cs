using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;

namespace ExerciseOne
{
    internal class SignInAccess
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public void btnSignIn_Click(TextBox txtUserName, TextBox txtUserPassword, String strUserName, String strUserPassword)
        {

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "select * from BTLLoginData where UserName='" + strUserName + "' and UserPassword='" + strUserPassword + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                ChooseForm newChooseForm = new ChooseForm();
                newChooseForm.Show();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!");
            }
            conn.Close();
        }
    }
}
