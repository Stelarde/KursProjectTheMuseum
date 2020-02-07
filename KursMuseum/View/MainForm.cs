using KursMuseum.Model;
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
            set
            {
                dgvMainTable.DataSource = value;
            }
        }
        public BindingList<String> TypeTickets
        {
            set => cbTypeTicket.DataSource = value;
        }

        public int SelectTypeTckets => cbTypeTicket.SelectedIndex;

        public double SelectMainTableInitialCost => (double)dgvMainTable.CurrentRow.Cells[5].Value;

        public string SelectMainTableTypeExcursion => (string)dgvMainTable.CurrentRow.Cells[0].Value;

        public DateTime SelectMainTableTimeStart => (DateTime)dgvMainTable.CurrentRow.Cells[1].Value;

        public DateTime SelectMainTableTimeFinish => (DateTime)dgvMainTable.CurrentRow.Cells[2].Value;

        public string SelectMainTableVenue => (string)dgvMainTable.CurrentRow.Cells[3].Value;

        public int SelectMainTableTicketLeft => (int)dgvMainTable.CurrentRow.Cells[4].Value;

        public string TypeTicket => (string)cbTypeTicket.SelectedItem;

        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler SoldTickets
        {
            add => btnSoldTicket.Click += value;
            remove => btnSoldTicket.Click -= value;
        }

        public event EventHandler SelectedTypeTicket
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

        public event EventHandler DeleteEx
        {
            add => btnDelExcursion.Click += value;
            remove => btnDelExcursion.Click -= value;
        }

        public event EventHandler SellTicket
        {
            add => btnSellTicket.Click += value;
            remove => btnSellTicket.Click -= value;
        }

        public event EventHandler CloseProgram
        {
            add => tsmClose.Click += value;
            remove => tsmClose.Click -= value;
        }
        public event EventHandler ReportShedule
        {
            add => tsmReport.Click += value;
            remove => tsmReport.Click -= value;
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
