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

namespace ExerciseOne
{
    public partial class Products : Form
    {
        ProductsAccess newproductsAccess = new ProductsAccess();


        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            btnUpdate.Hide();
            newproductsAccess.loadDataProducts(dgvProducts);
            newproductsAccess.loadItemID(cbItemID);
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtItemName.Text == "" || txtSize.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thêm");
            }
            else
            {
                try
                {
                    newproductsAccess.btnAdd_Click(txtItemName, cbItemID, txtSize);
                    newproductsAccess.loadDataProducts(dgvProducts);
                    newproductsAccess.loadItemID(cbItemID);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa");
            }
            else
            {
                try
                {
                    newproductsAccess.btnDelete_Click(txtItemName,dgvProducts, btnAdd, cbItemID, txtSize);
                    newproductsAccess.loadDataProducts(dgvProducts);
                    newproductsAccess.loadItemID(cbItemID);
                    btnUpdate.Hide();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbItemID.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn ItemID cần sửa");
            }
            else
            {
                try
                {
                    newproductsAccess.btnUpdate_Click(txtItemName,txtSize, cbItemID);
                    cbItemID_SelectedIndexChanged(sender, e);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }

        private void cbItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.Show();
            newproductsAccess.cbItemID_SelectedIndexChanged(btnAdd, cbItemID,dgvProducts,txtItemName,txtSize);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            btnAdd.Show();
            cbItemID.ResetText();
            txtItemName.ResetText();
            txtSize.ResetText();
            newproductsAccess.loadDataProducts(dgvProducts);
            btnUpdate.Hide();
        }
    }
}
