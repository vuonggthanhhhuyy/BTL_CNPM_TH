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
    public partial class Agents : Form
    {
        AgentsAccess newAgents = new AgentsAccess();
        public Agents()
        {
            InitializeComponent();
        }

        private void Agents_Load(object sender, EventArgs e)
        {
            btnUpdate.Hide();
            newAgents.loadAgentID(cbAgentID);
            newAgents.loadDataAgents(dgvAgents);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtAgentName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thêm");
            }
            else
            {
                newAgents.btnAdd_Click(txtAgentName, txtAddress, cbAgentID);
                newAgents.loadAgentID(cbAgentID);
                newAgents.loadDataAgents(dgvAgents);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnUpdate.Hide();
            if(dgvAgents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa");
            }
            else
            {
                newAgents.btnDelete_Click(btnAdd, cbAgentID, txtAgentName, txtAddress, dgvAgents);
                newAgents.loadAgentID(cbAgentID);
                newAgents.loadDataAgents(dgvAgents);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cbAgentID.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn AgentID cần sửa");
            }
            else
            {
                newAgents.btnUpdate_Click(txtAgentName, txtAddress, cbAgentID);
                cbAgentID_SelectedIndexChanged(sender, e);
            }
        }

        private void cbAgentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.Show();
            btnAdd.Hide();
            newAgents.cbAgentID_SelectedIndexChanged(cbAgentID, dgvAgents, txtAgentName, txtAddress);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            btnUpdate.Hide();
            btnAdd.Show();
            cbAgentID.ResetText();
            txtAgentName.ResetText();
            txtAddress.ResetText();
            newAgents.loadAgentID(cbAgentID);
            newAgents.loadDataAgents(dgvAgents);
        }
    }
}
