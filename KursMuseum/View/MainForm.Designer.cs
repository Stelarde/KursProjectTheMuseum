namespace KursMuseum.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMainTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReport = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTypeTicket = new System.Windows.Forms.ComboBox();
            this.btnAddExcursion = new System.Windows.Forms.Button();
            this.txtPriceTicket = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSoldTicket = new System.Windows.Forms.Button();
            this.btnDelExcursion = new System.Windows.Forms.Button();
            this.btnChangeExcursion = new System.Windows.Forms.Button();
            this.btnSellTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMainTable
            // 
            this.dgvMainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvMainTable.Location = new System.Drawing.Point(0, 24);
            this.dgvMainTable.Name = "dgvMainTable";
            this.dgvMainTable.RowHeadersVisible = false;
            this.dgvMainTable.Size = new System.Drawing.Size(595, 317);
            this.dgvMainTable.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmClose});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(48, 20);
            this.tsmFile.Text = "Файл";
            // 
            // tsmClose
            // 
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(180, 22);
            this.tsmClose.Text = "Закрыть";
            // 
            // tsmReport
            // 
            this.tsmReport.Name = "tsmReport";
            this.tsmReport.Size = new System.Drawing.Size(140, 20);
            this.tsmReport.Text = "Отчет по расписанию";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTypeTicket);
            this.panel1.Controls.Add(this.btnAddExcursion);
            this.panel1.Controls.Add(this.txtPriceTicket);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSoldTicket);
            this.panel1.Controls.Add(this.btnDelExcursion);
            this.panel1.Controls.Add(this.btnChangeExcursion);
            this.panel1.Controls.Add(this.btnSellTicket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(601, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 317);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Тип билета";
            // 
            // cbTypeTicket
            // 
            this.cbTypeTicket.FormattingEnabled = true;
            this.cbTypeTicket.Location = new System.Drawing.Point(3, 25);
            this.cbTypeTicket.Name = "cbTypeTicket";
            this.cbTypeTicket.Size = new System.Drawing.Size(172, 21);
            this.cbTypeTicket.TabIndex = 13;
            // 
            // btnAddExcursion
            // 
            this.btnAddExcursion.Font = new System.Drawing.Font("Kunstler Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExcursion.Location = new System.Drawing.Point(3, 164);
            this.btnAddExcursion.Name = "btnAddExcursion";
            this.btnAddExcursion.Size = new System.Drawing.Size(172, 23);
            this.btnAddExcursion.TabIndex = 12;
            this.btnAddExcursion.Text = "Добавить";
            this.btnAddExcursion.UseVisualStyleBackColor = true;
            // 
            // txtPriceTicket
            // 
            this.txtPriceTicket.Location = new System.Drawing.Point(4, 69);
            this.txtPriceTicket.Name = "txtPriceTicket";
            this.txtPriceTicket.Size = new System.Drawing.Size(171, 20);
            this.txtPriceTicket.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kunstler Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Цена";
            // 
            // btnSoldTicket
            // 
            this.btnSoldTicket.Font = new System.Drawing.Font("Kunstler Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoldTicket.Location = new System.Drawing.Point(3, 251);
            this.btnSoldTicket.Name = "btnSoldTicket";
            this.btnSoldTicket.Size = new System.Drawing.Size(172, 63);
            this.btnSoldTicket.TabIndex = 3;
            this.btnSoldTicket.Text = "Проданные билеты";
            this.btnSoldTicket.UseVisualStyleBackColor = true;
            // 
            // btnDelExcursion
            // 
            this.btnDelExcursion.Font = new System.Drawing.Font("Kunstler Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelExcursion.Location = new System.Drawing.Point(4, 222);
            this.btnDelExcursion.Name = "btnDelExcursion";
            this.btnDelExcursion.Size = new System.Drawing.Size(172, 23);
            this.btnDelExcursion.TabIndex = 2;
            this.btnDelExcursion.Text = "Удалить";
            this.btnDelExcursion.UseVisualStyleBackColor = true;
            // 
            // btnChangeExcursion
            // 
            this.btnChangeExcursion.Font = new System.Drawing.Font("Kunstler Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeExcursion.Location = new System.Drawing.Point(3, 193);
            this.btnChangeExcursion.Name = "btnChangeExcursion";
            this.btnChangeExcursion.Size = new System.Drawing.Size(172, 23);
            this.btnChangeExcursion.TabIndex = 1;
            this.btnChangeExcursion.Text = "Изменить";
            this.btnChangeExcursion.UseVisualStyleBackColor = true;
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.Font = new System.Drawing.Font("Kunstler Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellTicket.Location = new System.Drawing.Point(4, 95);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(172, 63);
            this.btnSellTicket.TabIndex = 0;
            this.btnSellTicket.Text = "Продать билет";
            this.btnSellTicket.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMainTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Продажа билетов";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMainTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSoldTicket;
        private System.Windows.Forms.Button btnDelExcursion;
        private System.Windows.Forms.Button btnChangeExcursion;
        private System.Windows.Forms.Button btnSellTicket;
        private System.Windows.Forms.TextBox txtPriceTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeExcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeFinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddExcursion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTypeTicket;
        private System.Windows.Forms.ToolStripMenuItem tsmReport;
    }
}

