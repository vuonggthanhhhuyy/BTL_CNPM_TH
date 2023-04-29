namespace ExerciseOne
{
    partial class Products
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblItemID = new System.Windows.Forms.Label();
            this.cbItemID = new System.Windows.Forms.ComboBox();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 68);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(776, 370);
            this.dgvProducts.TabIndex = 0;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(12, 15);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(72, 16);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "ItemName:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(12, 43);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(36, 16);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(90, 12);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(168, 22);
            this.txtItemName.TabIndex = 4;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(90, 40);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(168, 22);
            this.txtSize.TabIndex = 5;
            this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(264, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(264, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(713, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(498, 15);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(48, 16);
            this.lblItemID.TabIndex = 10;
            this.lblItemID.Text = "ItemID:";
            // 
            // cbItemID
            // 
            this.cbItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemID.FormattingEnabled = true;
            this.cbItemID.Location = new System.Drawing.Point(552, 12);
            this.cbItemID.Name = "cbItemID";
            this.cbItemID.Size = new System.Drawing.Size(155, 24);
            this.cbItemID.TabIndex = 11;
            this.cbItemID.SelectedIndexChanged += new System.EventHandler(this.cbItemID_SelectedIndexChanged);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(713, 43);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 12;
            this.btnAll.Text = "Tất cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.cbItemID);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.dgvProducts);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.ComboBox cbItemID;
        private System.Windows.Forms.Button btnAll;
    }
}