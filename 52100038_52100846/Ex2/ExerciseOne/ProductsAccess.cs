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
    internal class ProductsAccess
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public void loadItemID(ComboBox cbItemID)
        {
            cbItemID.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Item";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    cbItemID.Items.Add(dataReader["ItemID"].ToString());
                }
                dataReader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public void loadDataProducts(DataGridView dgvProducts)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Item";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
                da.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public void btnAdd_Click(TextBox txtItemName, ComboBox cbItemID, TextBox txtSize)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "exec InsertItem '" + txtItemName.Text + "', " + txtSize.Text;
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            cbItemID.ResetText();
            txtItemName.ResetText();
            txtSize.ResetText();
        }

        public void btnDelete_Click(TextBox txtItemName,DataGridView dgvProducts,Button btnAdd,ComboBox cbItemID, TextBox txtSize)
        {
            DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
            string ItemID = Convert.ToString(selectedRow.Cells["ItemID"].Value);
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand anotherCmd = new SqlCommand("delete from OrderDetail where ItemID = @ItemID", conn);
            anotherCmd.Parameters.AddWithValue("@ItemID", ItemID);
            anotherCmd.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand("delete from Item where ItemID = @ItemID", conn);
            cmd.Parameters.AddWithValue("@ItemID", ItemID);
            cmd.ExecuteNonQuery();
            conn.Close();
            btnAdd.Show();
            cbItemID.ResetText();
            txtItemName.ResetText();
            txtSize.ResetText();
        }

        public void btnUpdate_Click(TextBox txtItemName, TextBox txtSize, ComboBox cbItemID)
        {

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "update Item set ItemName = '" + txtItemName.Text + "', Size = " + Convert.ToInt32(txtSize.Text) + " where ItemID = '" + cbItemID.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();    
        }
        public void cbItemID_SelectedIndexChanged(Button btnAdd,ComboBox cbItemID, DataGridView dgvProducts, TextBox txtItemName, TextBox txtSize)
        {
            btnAdd.Hide();
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Item where ItemID = '" + cbItemID.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
                da.Dispose();
                conn.Close();
                foreach (DataRow row in dt.Rows)
                {
                    txtItemName.Text = row["ItemName"].ToString();
                    txtSize.Text = row["Size"].ToString();
                    break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

    }
}
