using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseOne
{
    internal class SignUpAccess
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public string setFormatDate(string datetime)
        {
            string[] temp = datetime.Split('/');
            string result = temp[2] + "-" + temp[0] + "-" + temp[1];
            return result;
        }
        public void setFormatDateOfBirth(DateTimePicker dtpDateOfBirth)
        {
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = "yyyy-MM-dd";
        }

        public void loadProvinceName(ComboBox cbProvince)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from ProvinceList";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    cbProvince.Items.Add(dataReader["Province"].ToString());
                }
                dataReader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

        }

        public void btnSignUp_Click(TextBox txtUserName, TextBox txtUserPassword, TextBox txtFullName, DateTimePicker dtpDateOfBirth, TextBox txtPhoneNumber, ComboBox cbProvince)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "select * from BTLLoginData where UserName='" + txtUserName.Text + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Tài khoản đã được đăng ký!");
            }
            else
            {
                String anotherStringSQL = "insert into BTLLoginData values ('" + txtUserName.Text + "', '" + txtUserPassword.Text + "', '" + txtFullName.Text + "', '" + setFormatDate(dtpDateOfBirth.Value.ToShortDateString()) + "', '" + txtPhoneNumber.Text + "', '" + cbProvince.SelectedItem.ToString() + "')";
                SqlCommand anotherCmd = new SqlCommand(anotherStringSQL, conn);
                anotherCmd.ExecuteNonQuery();
                MessageBox.Show("Đăng ký tài khoản thành công!");
            }
            conn.Close();
        }
    }
}
