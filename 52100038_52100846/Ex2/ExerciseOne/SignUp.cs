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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExerciseOne
{
    public partial class SignUp : Form
    {
        SignUpAccess newSignUpAccess = new SignUpAccess();

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            newSignUpAccess.setFormatDateOfBirth(dtpDateOfBirth);
            newSignUpAccess.loadProvinceName(cbProvince);
            txtUserPassword.PasswordChar = '*';
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "" || txtUserPassword.Text == "" || txtFullName.Text == "" || txtPhoneNumber.Text == "" || cbProvince.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    newSignUpAccess.btnSignUp_Click(txtUserName,txtUserPassword,txtFullName,dtpDateOfBirth,txtPhoneNumber,cbProvince);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
