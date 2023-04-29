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
    internal class FilterAccess
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public void btnBestCustomer_Click(DataGridView dgvShowOutput)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select Agent.AgentID, Agent.AgentName, count([Order].OrderID) as TotalOrders from Agent left join [Order] on Agent.AgentID = [Order].AgentID group by Agent.AgentID, Agent.AgentName order by TotalOrders desc";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvShowOutput.DataSource = dt;
                da.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public void btnBestSeller_Click(DataGridView dgvShowOutput)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select Item.ItemID, Item.ItemName, sum(OrderDetail.Quantity) as TotalQuantity from Item inner join OrderDetail on Item.ItemID = OrderDetail.ItemID group by Item.ItemID, Item.ItemName order by TotalQuantity desc";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvShowOutput.DataSource = dt;
                da.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
