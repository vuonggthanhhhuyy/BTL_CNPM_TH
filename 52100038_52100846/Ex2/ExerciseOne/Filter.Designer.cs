namespace ExerciseOne
{
    partial class Filter
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
            this.dgvShowOutput = new System.Windows.Forms.DataGridView();
            this.btnBestCustomer = new System.Windows.Forms.Button();
            this.btnBestSeller = new System.Windows.Forms.Button();
            this.lblChooseMethodFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowOutput
            // 
            this.dgvShowOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowOutput.Location = new System.Drawing.Point(9, 10);
            this.dgvShowOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvShowOutput.Name = "dgvShowOutput";
            this.dgvShowOutput.RowHeadersWidth = 51;
            this.dgvShowOutput.RowTemplate.Height = 24;
            this.dgvShowOutput.Size = new System.Drawing.Size(760, 323);
            this.dgvShowOutput.TabIndex = 0;
            // 
            // btnBestCustomer
            // 
            this.btnBestCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestCustomer.Location = new System.Drawing.Point(393, 340);
            this.btnBestCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBestCustomer.Name = "btnBestCustomer";
            this.btnBestCustomer.Size = new System.Drawing.Size(175, 58);
            this.btnBestCustomer.TabIndex = 1;
            this.btnBestCustomer.Text = "Khách hàng mua nhiều nhất";
            this.btnBestCustomer.UseVisualStyleBackColor = true;
            this.btnBestCustomer.Click += new System.EventHandler(this.btnBestCustomer_Click);
            // 
            // btnBestSeller
            // 
            this.btnBestSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestSeller.Location = new System.Drawing.Point(594, 340);
            this.btnBestSeller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBestSeller.Name = "btnBestSeller";
            this.btnBestSeller.Size = new System.Drawing.Size(175, 58);
            this.btnBestSeller.TabIndex = 2;
            this.btnBestSeller.Text = "Mặt hàng bán chạy nhất";
            this.btnBestSeller.UseVisualStyleBackColor = true;
            this.btnBestSeller.Click += new System.EventHandler(this.btnBestSeller_Click);
            // 
            // lblChooseMethodFilter
            // 
            this.lblChooseMethodFilter.AutoSize = true;
            this.lblChooseMethodFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseMethodFilter.Location = new System.Drawing.Point(11, 359);
            this.lblChooseMethodFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChooseMethodFilter.Name = "lblChooseMethodFilter";
            this.lblChooseMethodFilter.Size = new System.Drawing.Size(291, 20);
            this.lblChooseMethodFilter.TabIndex = 3;
            this.lblChooseMethodFilter.Text = "Hãy chọn phương thức muốn lọc dữ liệu:";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 425);
            this.Controls.Add(this.lblChooseMethodFilter);
            this.Controls.Add(this.btnBestSeller);
            this.Controls.Add(this.btnBestCustomer);
            this.Controls.Add(this.dgvShowOutput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Filter";
            this.Text = "Filter";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowOutput;
        private System.Windows.Forms.Button btnBestCustomer;
        private System.Windows.Forms.Button btnBestSeller;
        private System.Windows.Forms.Label lblChooseMethodFilter;
    }
}