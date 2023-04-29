namespace ExerciseOne
{
    partial class ChooseForm
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
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnAgents = new System.Windows.Forms.Button();
            this.btnOrderForm = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(12, 12);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(83, 75);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnAgents
            // 
            this.btnAgents.Location = new System.Drawing.Point(101, 12);
            this.btnAgents.Name = "btnAgents";
            this.btnAgents.Size = new System.Drawing.Size(83, 75);
            this.btnAgents.TabIndex = 1;
            this.btnAgents.Text = "Agents";
            this.btnAgents.UseVisualStyleBackColor = true;
            this.btnAgents.Click += new System.EventHandler(this.btnAgents_Click);
            // 
            // btnOrderForm
            // 
            this.btnOrderForm.Location = new System.Drawing.Point(190, 12);
            this.btnOrderForm.Name = "btnOrderForm";
            this.btnOrderForm.Size = new System.Drawing.Size(83, 75);
            this.btnOrderForm.TabIndex = 2;
            this.btnOrderForm.Text = "OrderForm";
            this.btnOrderForm.UseVisualStyleBackColor = true;
            this.btnOrderForm.Click += new System.EventHandler(this.btnOrderForm_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(279, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(83, 75);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 100);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnOrderForm);
            this.Controls.Add(this.btnAgents);
            this.Controls.Add(this.btnProducts);
            this.Name = "ChooseForm";
            this.Text = "ChooseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnAgents;
        private System.Windows.Forms.Button btnOrderForm;
        private System.Windows.Forms.Button btnFilter;
    }
}