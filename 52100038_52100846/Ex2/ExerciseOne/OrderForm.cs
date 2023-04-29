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
    public partial class OrderForm : Form
    {
        OrderFormAccess newOrderFormAccess = new OrderFormAccess();
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            newOrderFormAccess.loadDataOrder(dgvOrder);
            newOrderFormAccess.loadOrderID(cbOrderID);
            newOrderFormAccess.loadDataOrderDetail(null, dgvOrderDetail);
            btnPrint.Hide();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cbOrderID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn OrderID");
            }
            else
            {
                newOrderFormAccess.btnFind_Click(cbOrderID, dgvOrder, btnPrint);
                newOrderFormAccess.loadDataOrderDetail(cbOrderID.SelectedItem.ToString(), dgvOrderDetail);
                
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            
            newOrderFormAccess.loadOrderID(cbOrderID);
            newOrderFormAccess.loadDataOrder(dgvOrder);
            newOrderFormAccess.loadDataOrderDetail(null, dgvOrderDetail);
            btnPrint.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            newOrderFormAccess.btnPrint_Click(dgvOrderDetail);
        }
    }
}
