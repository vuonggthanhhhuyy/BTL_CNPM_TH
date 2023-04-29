using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        #region Properties

        private string _title;
        private string _description;
        private Image _pic;

        [Category("Custom Props")]
        public string Title { get { return _title; } set { _title = value; lblTopic.Text = value; } }
        [Category("Custom Props")]
        public string Description { get { return _description;} set { _description = value; lblDescription.Text = value; } }
        [Category("Custom Props")]
        public Image Picture { get { return _pic;} set { _pic = value; pictureBox1.Image = value; } }
        #endregion

        private void btnButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã mua 1 vé " + lblTopic.Text + ". Hãy thanh toán!");
        }
    }
}
