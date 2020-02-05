namespace KursMuseum.View
{
    partial class CreatedEx
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
            this.button1 = new System.Windows.Forms.Button();
            this.NameEx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimeStartEx = new System.Windows.Forms.DateTimePicker();
            this.DateTimeFinishEx = new System.Windows.Forms.DateTimePicker();
            this.tbVenue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQuantityTickets = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStartPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Kunstler Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(409, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 109);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NameEx
            // 
            this.NameEx.Location = new System.Drawing.Point(12, 25);
            this.NameEx.Name = "NameEx";
            this.NameEx.Size = new System.Drawing.Size(226, 20);
            this.NameEx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите название экскурсии";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите дату и время начала экскурсии";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите дату и время конца экскурсии";
            // 
            // DateTimeStartEx
            // 
            this.DateTimeStartEx.CustomFormat = "d.MM.yyyy HH:m";
            this.DateTimeStartEx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeStartEx.Location = new System.Drawing.Point(12, 62);
            this.DateTimeStartEx.Name = "DateTimeStartEx";
            this.DateTimeStartEx.Size = new System.Drawing.Size(226, 20);
            this.DateTimeStartEx.TabIndex = 12;
            // 
            // DateTimeFinishEx
            // 
            this.DateTimeFinishEx.CustomFormat = "d.MM.yyyy HH:m";
            this.DateTimeFinishEx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeFinishEx.Location = new System.Drawing.Point(12, 101);
            this.DateTimeFinishEx.Name = "DateTimeFinishEx";
            this.DateTimeFinishEx.Size = new System.Drawing.Size(226, 20);
            this.DateTimeFinishEx.TabIndex = 13;
            // 
            // tbVenue
            // 
            this.tbVenue.Location = new System.Drawing.Point(252, 25);
            this.tbVenue.Name = "tbVenue";
            this.tbVenue.Size = new System.Drawing.Size(151, 20);
            this.tbVenue.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Введите место сбора";
            // 
            // tbQuantityTickets
            // 
            this.tbQuantityTickets.Location = new System.Drawing.Point(252, 62);
            this.tbQuantityTickets.Name = "tbQuantityTickets";
            this.tbQuantityTickets.Size = new System.Drawing.Size(151, 20);
            this.tbQuantityTickets.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Введите количество билетов";
            // 
            // tbStartPrice
            // 
            this.tbStartPrice.Location = new System.Drawing.Point(252, 101);
            this.tbStartPrice.Name = "tbStartPrice";
            this.tbStartPrice.Size = new System.Drawing.Size(151, 20);
            this.tbStartPrice.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Начальная стоимость билета";
            // 
            // CreatedEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 133);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbStartPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbQuantityTickets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVenue);
            this.Controls.Add(this.DateTimeFinishEx);
            this.Controls.Add(this.DateTimeStartEx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameEx);
            this.Controls.Add(this.button1);
            this.Name = "CreatedEx";
            this.Text = "Добавить экскурсию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NameEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateTimeStartEx;
        private System.Windows.Forms.DateTimePicker DateTimeFinishEx;
        private System.Windows.Forms.TextBox tbVenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbQuantityTickets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStartPrice;
        private System.Windows.Forms.Label label6;
    }
}