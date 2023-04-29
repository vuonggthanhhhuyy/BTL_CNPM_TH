using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ExerciseOne
{
    public partial class Filter : Form
    {
        FilterAccess newFilterAccess = new FilterAccess();
        public Filter()
        {
            InitializeComponent();
        }

        private void btnBestCustomer_Click(object sender, EventArgs e)
        {
            newFilterAccess.btnBestCustomer_Click(dgvShowOutput);
        }

        private void btnBestSeller_Click(object sender, EventArgs e)
        {
            newFilterAccess.btnBestSeller_Click(dgvShowOutput);
        }
    }
}
