namespace KursMuseum.View
{
    partial class SellForm
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
            this.dgvSellTicket = new System.Windows.Forms.DataGridView();
            this.btnDelTL = new System.Windows.Forms.Button();
            this.btnChangeTL = new System.Windows.Forms.Button();
            this.btnReportSellTicket = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAllSales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellTicket)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSellTicket
            // 
            this.dgvSellTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellTicket.Location = new System.Drawing.Point(0, 0);
            this.dgvSellTicket.Name = "dgvSellTicket";
            this.dgvSellTicket.Size = new System.Drawing.Size(593, 286);
            this.dgvSellTicket.TabIndex = 0;
            // 
            // btnDelTL
            // 
            this.btnDelTL.Location = new System.Drawing.Point(601, 60);
            this.btnDelTL.Name = "btnDelTL";
            this.btnDelTL.Size = new System.Drawing.Size(165, 25);
            this.btnDelTL.TabIndex = 2;
            this.btnDelTL.Text = "Удалить";
            this.btnDelTL.UseVisualStyleBackColor = true;
            // 
            // btnChangeTL
            // 
            this.btnChangeTL.Font = new System.Drawing.Font("Kunstler Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTL.Location = new System.Drawing.Point(601, 29);
            this.btnChangeTL.Name = "btnChangeTL";
            this.btnChangeTL.Size = new System.Drawing.Size(165, 25);
            this.btnChangeTL.TabIndex = 3;
            this.btnChangeTL.Text = "Изменить";
            this.btnChangeTL.UseVisualStyleBackColor = true;
            // 
            // btnReportSellTicket
            // 
            this.btnReportSellTicket.Font = new System.Drawing.Font("Kunstler Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportSellTicket.Location = new System.Drawing.Point(601, 239);
            this.btnReportSellTicket.Name = "btnReportSellTicket";
            this.btnReportSellTicket.Size = new System.Drawing.Size(165, 50);
            this.btnReportSellTicket.TabIndex = 4;
            this.btnReportSellTicket.Text = "Отчет по проданным билетам";
            this.btnReportSellTicket.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSellTicket);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 292);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // tbAllSales
            // 
            this.tbAllSales.Location = new System.Drawing.Point(601, 213);
            this.tbAllSales.Name = "tbAllSales";
            this.tbAllSales.Size = new System.Drawing.Size(165, 20);
            this.tbAllSales.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kunstler Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вырученные средства";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(601, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2020, 1, 26, 0, 0, 0, 0);
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 294);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAllSales);
            this.Controls.Add(this.btnChangeTL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReportSellTicket);
            this.Controls.Add(this.btnDelTL);
            this.Name = "SellForm";
            this.Text = "Проданные билеты";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellTicket)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSellTicket;
        private System.Windows.Forms.Button btnDelTL;
        private System.Windows.Forms.Button btnChangeTL;
        private System.Windows.Forms.Button btnReportSellTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameExDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeStartExDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeFinishExDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox tbAllSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}