namespace Tax_Service
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGetTaxRate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.dgvRate = new System.Windows.Forms.DataGridView();
            this.txtTaxForOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaxForOrder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetTaxRate
            // 
            this.btnGetTaxRate.Location = new System.Drawing.Point(311, 109);
            this.btnGetTaxRate.Name = "btnGetTaxRate";
            this.btnGetTaxRate.Size = new System.Drawing.Size(112, 37);
            this.btnGetTaxRate.TabIndex = 0;
            this.btnGetTaxRate.Text = "Get Tax Rate";
            this.btnGetTaxRate.UseVisualStyleBackColor = true;
            this.btnGetTaxRate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zip Code";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(103, 116);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(173, 22);
            this.txtZip.TabIndex = 2;
            // 
            // dgvRate
            // 
            this.dgvRate.AllowUserToAddRows = false;
            this.dgvRate.AllowUserToDeleteRows = false;
            this.dgvRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRate.Location = new System.Drawing.Point(35, 152);
            this.dgvRate.Name = "dgvRate";
            this.dgvRate.ReadOnly = true;
            this.dgvRate.RowHeadersWidth = 51;
            this.dgvRate.RowTemplate.Height = 24;
            this.dgvRate.Size = new System.Drawing.Size(1658, 103);
            this.dgvRate.TabIndex = 3;
            // 
            // txtTaxForOrder
            // 
            this.txtTaxForOrder.Location = new System.Drawing.Point(942, 116);
            this.txtTaxForOrder.Name = "txtTaxForOrder";
            this.txtTaxForOrder.ReadOnly = true;
            this.txtTaxForOrder.Size = new System.Drawing.Size(114, 22);
            this.txtTaxForOrder.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(856, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tax Amount";
            // 
            // btnTaxForOrder
            // 
            this.btnTaxForOrder.Location = new System.Drawing.Point(1081, 109);
            this.btnTaxForOrder.Name = "btnTaxForOrder";
            this.btnTaxForOrder.Size = new System.Drawing.Size(136, 37);
            this.btnTaxForOrder.TabIndex = 4;
            this.btnTaxForOrder.Text = "Get Tax for Order";
            this.btnTaxForOrder.UseVisualStyleBackColor = true;
            this.btnTaxForOrder.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1658, 59);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1705, 271);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTaxForOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTaxForOrder);
            this.Controls.Add(this.dgvRate);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetTaxRate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetTaxRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.DataGridView dgvRate;
        private System.Windows.Forms.TextBox txtTaxForOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTaxForOrder;
        private System.Windows.Forms.TextBox textBox1;
    }
}

