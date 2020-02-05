namespace KursMuseum.View
{
    partial class ChangeEx
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
            this.tbNameEx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimeStartEx = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimeFinishEx = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVenue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbQuantityTickets = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStartPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbExcurs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название экскурсии";
            // 
            // tbNameEx
            // 
            this.tbNameEx.Location = new System.Drawing.Point(15, 58);
            this.tbNameEx.Name = "tbNameEx";
            this.tbNameEx.Size = new System.Drawing.Size(200, 20);
            this.tbNameEx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите дату и время начала экскурсии";
            // 
            // DateTimeStartEx
            // 
            this.DateTimeStartEx.CustomFormat = "d.MM.yyyy HH:m";
            this.DateTimeStartEx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeStartEx.Location = new System.Drawing.Point(15, 97);
            this.DateTimeStartEx.Name = "DateTimeStartEx";
            this.DateTimeStartEx.Size = new System.Drawing.Size(200, 20);
            this.DateTimeStartEx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите дату и время конца экскурсии";
            // 
            // DateTimeFinishEx
            // 
            this.DateTimeFinishEx.CustomFormat = "d.MM.yyyy HH:m";
            this.DateTimeFinishEx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeFinishEx.Location = new System.Drawing.Point(15, 136);
            this.DateTimeFinishEx.Name = "DateTimeFinishEx";
            this.DateTimeFinishEx.Size = new System.Drawing.Size(200, 20);
            this.DateTimeFinishEx.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите место сбора";
            // 
            // tbVenue
            // 
            this.tbVenue.Location = new System.Drawing.Point(232, 58);
            this.tbVenue.Name = "tbVenue";
            this.tbVenue.Size = new System.Drawing.Size(176, 20);
            this.tbVenue.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Введите количество билетов";
            // 
            // tbQuantityTickets
            // 
            this.tbQuantityTickets.Location = new System.Drawing.Point(232, 97);
            this.tbQuantityTickets.Name = "tbQuantityTickets";
            this.tbQuantityTickets.Size = new System.Drawing.Size(176, 20);
            this.tbQuantityTickets.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Начальная стоимость билета";
            // 
            // tbStartPrice
            // 
            this.tbStartPrice.Location = new System.Drawing.Point(232, 136);
            this.tbStartPrice.Name = "tbStartPrice";
            this.tbStartPrice.Size = new System.Drawing.Size(176, 20);
            this.tbStartPrice.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Kunstler Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(414, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 115);
            this.button1.TabIndex = 13;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbExcurs
            // 
            this.cmbExcurs.FormattingEnabled = true;
            this.cmbExcurs.Location = new System.Drawing.Point(15, 12);
            this.cmbExcurs.Name = "cmbExcurs";
            this.cmbExcurs.Size = new System.Drawing.Size(200, 21);
            this.cmbExcurs.TabIndex = 14;
            // 
            // ChangeEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 171);
            this.Controls.Add(this.cmbExcurs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbStartPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbQuantityTickets);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbVenue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateTimeFinishEx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTimeStartEx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNameEx);
            this.Controls.Add(this.label1);
            this.Name = "ChangeEx";
            this.Text = "Изменить экскурсию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTimeStartEx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTimeFinishEx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVenue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbQuantityTickets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbStartPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbExcurs;
    }
}