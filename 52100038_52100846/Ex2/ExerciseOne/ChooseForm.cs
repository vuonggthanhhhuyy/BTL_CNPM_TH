using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseOne
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products newProduct = new Products();
            newProduct.Show();
        }

        private void btnAgents_Click(object sender, EventArgs e)
        {
            Agents newAgent = new Agents();
            newAgent.Show();
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            OrderForm newOrderForm = new OrderForm();
            newOrderForm.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter newFilter = new Filter();
            newFilter.Show();
        }
    }
}
