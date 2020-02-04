﻿using KursMuseum.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursMuseum.View
{
    public partial class MainForm : Form, IMainForm
    {
        public double PriceTickets
        {
            get => double.Parse(txtPriceTicket.Text);
            set => txtPriceTicket.Text = Convert.ToString(value);
        }
        public BindingList<ScheduleExcursionItem> ScheduleExcursionItems
        {
            get => dgvMainTable.DataSource as BindingList<ScheduleExcursionItem>;
            set => dgvMainTable.DataSource = value;
        }
        public BindingList<String> TypeTickets
        {
            set => cbTypeTicket.DataSource = value;
        }

        public int SelectTypeTckets => cbTypeTicket.SelectedIndex;

        public double SelectMainTable => (double)dgvMainTable.CurrentRow.Cells[5].Value;

        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler SoldTickets
        {
            add => btnSoldTicket.Click += value;
            remove => btnSoldTicket.Click -= value;
        }

        public event EventHandler TypeTicket
        {
            add => cbTypeTicket.SelectedIndexChanged += value;
            remove => cbTypeTicket.SelectedIndexChanged -= value;
        }

        public event EventHandler MainTable
        {
            add => dgvMainTable.SelectionChanged += value;
            remove => dgvMainTable.SelectionChanged -= value;
        }

        public event EventHandler ChangeEx
        {
            add => btnChangeExcursion.Click += value;
            remove => btnChangeExcursion.Click -= value;
        }

        public new void Show()
        {
            Application.Run(this);
        }
        public event EventHandler AddEx
        {
            add => btnAddExcursion.Click += value;
            remove => btnAddExcursion.Click -= value;
        }
    }
}
