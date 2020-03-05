namespace IncomeWinTech
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ImportIncome = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ImportCatalog = new System.Windows.Forms.Button();
            this.btn_ChangeId = new System.Windows.Forms.Button();
            this.btn_ExportIncome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_ImportIncome
            // 
            this.btn_ImportIncome.Location = new System.Drawing.Point(33, 92);
            this.btn_ImportIncome.Name = "btn_ImportIncome";
            this.btn_ImportIncome.Size = new System.Drawing.Size(108, 22);
            this.btn_ImportIncome.TabIndex = 2;
            this.btn_ImportIncome.Text = "Импорт прихода";
            this.btn_ImportIncome.UseVisualStyleBackColor = true;
            this.btn_ImportIncome.Click += new System.EventHandler(this.btn_ImportIncome_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 227);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_ImportCatalog
            // 
            this.btn_ImportCatalog.Location = new System.Drawing.Point(33, 46);
            this.btn_ImportCatalog.Name = "btn_ImportCatalog";
            this.btn_ImportCatalog.Size = new System.Drawing.Size(108, 20);
            this.btn_ImportCatalog.TabIndex = 7;
            this.btn_ImportCatalog.Text = "Ипорт Каталога";
            this.btn_ImportCatalog.UseVisualStyleBackColor = true;
            this.btn_ImportCatalog.Click += new System.EventHandler(this.btn_ImportCatalog_Click);
            // 
            // btn_ChangeId
            // 
            this.btn_ChangeId.Location = new System.Drawing.Point(55, 396);
            this.btn_ChangeId.Name = "btn_ChangeId";
            this.btn_ChangeId.Size = new System.Drawing.Size(75, 42);
            this.btn_ChangeId.TabIndex = 8;
            this.btn_ChangeId.Text = "Заменить артикула";
            this.btn_ChangeId.UseVisualStyleBackColor = true;
            this.btn_ChangeId.Click += new System.EventHandler(this.btn_ChangeId_Click);
            // 
            // btn_ExportIncome
            // 
            this.btn_ExportIncome.Location = new System.Drawing.Point(282, 396);
            this.btn_ExportIncome.Name = "btn_ExportIncome";
            this.btn_ExportIncome.Size = new System.Drawing.Size(101, 42);
            this.btn_ExportIncome.TabIndex = 9;
            this.btn_ExportIncome.Text = "Экспортировать приход";
            this.btn_ExportIncome.UseVisualStyleBackColor = true;
            this.btn_ExportIncome.Click += new System.EventHandler(this.btn_ExportIncome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ExportIncome);
            this.Controls.Add(this.btn_ChangeId);
            this.Controls.Add(this.btn_ImportCatalog);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_ImportIncome);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ImportIncome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ImportCatalog;
        private System.Windows.Forms.Button btn_ChangeId;
        private System.Windows.Forms.Button btn_ExportIncome;
    }
}

