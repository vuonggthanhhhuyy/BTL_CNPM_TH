namespace ExerciseOne
{
    partial class Agents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAgentName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblAgentID = new System.Windows.Forms.Label();
            this.cbAgentID = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.dgvAgents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgentName
            // 
            this.lblAgentName.AutoSize = true;
            this.lblAgentName.Location = new System.Drawing.Point(12, 9);
            this.lblAgentName.Name = "lblAgentName";
            this.lblAgentName.Size = new System.Drawing.Size(82, 16);
            this.lblAgentName.TabIndex = 0;
            this.lblAgentName.Text = "AgentName:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 37);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 16);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // txtAgentName
            // 
            this.txtAgentName.Location = new System.Drawing.Point(100, 6);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(187, 22);
            this.txtAgentName.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(100, 34);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(187, 22);
            this.txtAddress.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(293, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(293, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblAgentID
            // 
            this.lblAgentID.AutoSize = true;
            this.lblAgentID.Location = new System.Drawing.Point(459, 9);
            this.lblAgentID.Name = "lblAgentID";
            this.lblAgentID.Size = new System.Drawing.Size(58, 16);
            this.lblAgentID.TabIndex = 11;
            this.lblAgentID.Text = "AgentID:";
            // 
            // cbAgentID
            // 
            this.cbAgentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgentID.FormattingEnabled = true;
            this.cbAgentID.Location = new System.Drawing.Point(523, 6);
            this.cbAgentID.Name = "cbAgentID";
            this.cbAgentID.Size = new System.Drawing.Size(184, 24);
            this.cbAgentID.TabIndex = 12;
            this.cbAgentID.SelectedIndexChanged += new System.EventHandler(this.cbAgentID_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(713, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(713, 37);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 14;
            this.btnAll.Text = "Tất cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // dgvAgents
            // 
            this.dgvAgents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgents.Location = new System.Drawing.Point(13, 67);
            this.dgvAgents.Name = "dgvAgents";
            this.dgvAgents.RowHeadersWidth = 51;
            this.dgvAgents.RowTemplate.Height = 24;
            this.dgvAgents.Size = new System.Drawing.Size(776, 372);
            this.dgvAgents.TabIndex = 15;
            // 
            // Agents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAgents);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbAgentID);
            this.Controls.Add(this.lblAgentID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAgentName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblAgentName);
            this.Name = "Agents";
            this.Text = "Agents";
            this.Load += new System.EventHandler(this.Agents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgentName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAgentID;
        private System.Windows.Forms.ComboBox cbAgentID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.DataGridView dgvAgents;
    }
}