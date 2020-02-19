namespace KursMuseum.View
{
    partial class ChangeSell
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
            this.tbNameExcurs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSell = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTypeTicket = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPriceTicket = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpTimeStartExcurs = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeSellTicket = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название экскурсии";
            // 
            // tbNameExcurs
            // 
            this.tbNameExcurs.Location = new System.Drawing.Point(15, 57);
            this.tbNameExcurs.Name = "tbNameExcurs";
            this.tbNameExcurs.Size = new System.Drawing.Size(150, 20);
            this.tbNameExcurs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Время начала экскурсии";
            // 
            // cbSell
            // 
            this.cbSell.FormattingEnabled = true;
            this.cbSell.Location = new System.Drawing.Point(15, 12);
            this.cbSell.Name = "cbSell";
            this.cbSell.Size = new System.Drawing.Size(307, 21);
            this.cbSell.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип билета";
            // 
            // tbTypeTicket
            // 
            this.tbTypeTicket.Location = new System.Drawing.Point(15, 135);
            this.tbTypeTicket.Name = "tbTypeTicket";
            this.tbTypeTicket.Size = new System.Drawing.Size(150, 20);
            this.tbTypeTicket.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цена билета";
            // 
            // tbPriceTicket
            // 
            this.tbPriceTicket.Location = new System.Drawing.Point(172, 57);
            this.tbPriceTicket.Name = "tbPriceTicket";
            this.tbPriceTicket.Size = new System.Drawing.Size(150, 20);
            this.tbPriceTicket.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Время продажи билета";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Kunstler Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(171, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtpTimeStartExcurs
            // 
            this.dtpTimeStartExcurs.CustomFormat = "d.MM.yyyy HH:m";
            this.dtpTimeStartExcurs.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeStartExcurs.Location = new System.Drawing.Point(15, 96);
            this.dtpTimeStartExcurs.Name = "dtpTimeStartExcurs";
            this.dtpTimeStartExcurs.Size = new System.Drawing.Size(150, 20);
            this.dtpTimeStartExcurs.TabIndex = 14;
            // 
            // dtpTimeSellTicket
            // 
            this.dtpTimeSellTicket.CustomFormat = "d.MM.yyyy HH:m";
            this.dtpTimeSellTicket.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeSellTicket.Location = new System.Drawing.Point(171, 96);
            this.dtpTimeSellTicket.Name = "dtpTimeSellTicket";
            this.dtpTimeSellTicket.Size = new System.Drawing.Size(151, 20);
            this.dtpTimeSellTicket.TabIndex = 15;
            // 
            // ChangeSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 231);
            this.Controls.Add(this.dtpTimeSellTicket);
            this.Controls.Add(this.dtpTimeStartExcurs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPriceTicket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTypeTicket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNameExcurs);
            this.Controls.Add(this.label1);
            this.Name = "ChangeSell";
            this.Text = "Изменение проданного билета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameExcurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTypeTicket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPriceTicket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpTimeStartExcurs;
        private System.Windows.Forms.DateTimePicker dtpTimeSellTicket;
    }
}