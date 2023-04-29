namespace ExerciseOne
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.cbOrderID = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrderID:";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(11, 75);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(367, 327);
            this.dgvOrder.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(356, 19);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(93, 28);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(467, 19);
            this.btnAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(104, 28);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "Tất cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(390, 75);
            this.dgvOrderDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 24;
            this.dgvOrderDetail.Size = new System.Drawing.Size(367, 327);
            this.dgvOrderDetail.TabIndex = 5;
            // 
            // cbOrderID
            // 
            this.cbOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrderID.FormattingEnabled = true;
            this.cbOrderID.Location = new System.Drawing.Point(93, 19);
            this.cbOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbOrderID.Name = "cbOrderID";
            this.cbOrderID.Size = new System.Drawing.Size(243, 28);
            this.cbOrderID.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(629, 408);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(127, 39);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "IN ORDER DETAIL";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 457);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbOrderID);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.ComboBox cbOrderID;
        private System.Windows.Forms.Button btnPrint;
    }
}