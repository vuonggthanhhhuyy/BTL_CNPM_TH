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
    public partial class SignIn : Form
    {
        SignInAccess signInAccess = new SignInAccess();
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            String strUserName = txtUserName.Text;
            String strUserPassword = txtUserPassword.Text;
            try
            {
                signInAccess.btnSignIn_Click(txtUserName,txtUserPassword,strUserName,strUserPassword);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp newSignUp = new SignUp();
            newSignUp.Show();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            txtUserPassword.PasswordChar = '*';
        }
    }
}
