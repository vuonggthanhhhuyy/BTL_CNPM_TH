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
using Excel = Microsoft.Office.Interop.Excel;

namespace ExerciseOne
{
    internal class OrderFormAccess
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public void loadDataOrder(DataGridView dgvOrder)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from [Order]";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOrder.DataSource = dt;
                da.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        public void loadDataOrderDetail(string str, DataGridView dgvOrderDetail)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from OrderDetail where OrderID = '" + str + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOrderDetail.DataSource = dt;
                da.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public void loadOrderID(ComboBox cbOrderID)
        {
            cbOrderID.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from [Order]";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    cbOrderID.Items.Add(dataReader["OrderID"].ToString());
                }
                dataReader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public void btnFind_Click(ComboBox cbOrderID, DataGridView dgvOrder, Button btnPrint)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from [Order] where OrderID = '" + cbOrderID.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOrder.DataSource = dt;
                da.Dispose();
                conn.Close();
                btnPrint.Show();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        public void btnPrint_Click(DataGridView dgvOrderDetail)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Add();
            Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];

            DataTable dataTable = (DataTable)dgvOrderDetail.DataSource;

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                xlWorksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
                xlWorksheet.Range[xlWorksheet.Cells[1, i + 1], xlWorksheet.Cells[1, i + 1]].ColumnWidth = 15;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    xlWorksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j];
                }
            }

            if (dataTable.Rows.Count > 0)
            {
                int lastRow = xlWorksheet.UsedRange.Rows.Count + 1;
                int lastCol = xlWorksheet.UsedRange.Columns.Count;
                int col = 2;
                if (col <= lastCol && lastRow > 1)
                {
                    xlWorksheet.Range[xlWorksheet.Cells[1, col], xlWorksheet.Cells[lastRow, col]].ColumnWidth = 20;
                }
            }

            string fileName = "output.xlsx";
            string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), fileName);
            xlWorkbook.SaveAs(path);
            xlWorkbook.Close();
            xlApp.Quit();
            MessageBox.Show("In thành công vào thư mục .../bin/Debug/ của project");
        }


    }
}
