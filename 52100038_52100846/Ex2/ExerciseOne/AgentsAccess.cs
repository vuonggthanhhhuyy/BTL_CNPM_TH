using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseOne
{
    internal class AgentsAccess
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public void loadAgentID(ComboBox cbAgentID)
        {
            cbAgentID.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Agent";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    cbAgentID.Items.Add(dataReader["AgentID"].ToString());
                }
                dataReader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        public void loadDataAgents(DataGridView dgvAgents)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Agent";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAgents.DataSource = dt;
                da.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        public void btnAdd_Click(TextBox txtAgentName, TextBox txtAddress, ComboBox cbAgentID)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "exec InsertAgent '" + txtAgentName.Text + "', '" + txtAddress.Text + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                cbAgentID.ResetText();
                txtAgentName.ResetText();
                txtAddress.ResetText();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        public void btnDelete_Click(Button btnAdd, ComboBox cbAgentID, TextBox txtAgentName, TextBox txtAddress, DataGridView dgvAgents)
        {
            try
            {
                DataGridViewRow selectedRow = dgvAgents.SelectedRows[0];
                string AgentID = Convert.ToString(selectedRow.Cells["AgentID"].Value);
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand getOrderIDCmd = new SqlCommand("select OrderDetail.OrderID from OrderDetail, [Order], Agent where Agent.AgentID = @AgentID and Agent.AgentID = [Order].AgentID and OrderDetail.OrderID = [Order].OrderID", conn);
                getOrderIDCmd.Parameters.AddWithValue("@AgentID", AgentID);
                SqlDataReader dataReader = getOrderIDCmd.ExecuteReader();
                string OrderID = "";
                while (dataReader.Read())
                {
                    OrderID = dataReader["OrderID"].ToString();
                }
                dataReader.Close();
                SqlCommand differentAnotherCmd = new SqlCommand("delete from OrderDetail where OrderID = @OrderID", conn);
                differentAnotherCmd.Parameters.AddWithValue("@OrderID", OrderID);
                differentAnotherCmd.ExecuteNonQuery();
                SqlCommand anotherCmd = new SqlCommand("delete from [Order] where AgentID = @AgentID", conn);
                anotherCmd.Parameters.AddWithValue("@AgentID", AgentID);
                anotherCmd.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand("delete from Agent where AgentID = @AgentID", conn);
                cmd.Parameters.AddWithValue("@AgentID", AgentID);
                cmd.ExecuteNonQuery();
                conn.Close();
                btnAdd.Show();
                cbAgentID.ResetText();
                txtAgentName.ResetText();
                txtAddress.ResetText();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        public void btnUpdate_Click(TextBox txtAgentName, TextBox txtAddress, ComboBox cbAgentID)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "update Agent set AgentName = '" + txtAgentName.Text + "', Address = '" + txtAddress.Text + "' where AgentID = '" + cbAgentID.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        public void cbAgentID_SelectedIndexChanged(ComboBox cbAgentID, DataGridView dgvAgents, TextBox txtAgentName, TextBox txtAddress)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Agent where AgentID = '" + cbAgentID.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAgents.DataSource = dt;
                da.Dispose();
                conn.Close();
                foreach (DataRow row in dt.Rows)
                {
                    txtAgentName.Text = row["AgentName"].ToString();
                    txtAddress.Text = row["Address"].ToString();
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
