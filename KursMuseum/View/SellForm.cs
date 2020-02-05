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
    public partial class SellForm : Form, ISellForm
    {
        public SellForm()
        {
            InitializeComponent();            
        }
        public BindingList<SellTicket> SellTickets
        {
            get => dgvSellTicket.DataSource as BindingList<SellTicket>;
            set => dgvSellTicket.DataSource = value;
        }

        public string NameExcrusion => (string)dgvSellTicket.CurrentRow.Cells[0].Value;

        public DateTime TimeStart => (DateTime)dgvSellTicket.CurrentRow.Cells[1].Value;

        public string TypeTicket => (string)dgvSellTicket.CurrentRow.Cells[2].Value;

        public double PriceTicket => (double)dgvSellTicket.CurrentRow.Cells[3].Value;

        public DateTime SellTime => (DateTime)dgvSellTicket.CurrentRow.Cells[4].Value;

        public double AllSalles 
        {
            get => double.Parse(tbAllSales.Text);
            set => tbAllSales.Text = Convert.ToString(value); 
        }

        public DateTime SelectDate => (DateTime)dateTimePicker1.Value;

        public event EventHandler ChangeDateSell
        {
            add => dateTimePicker1.ValueChanged += value;
            remove => dateTimePicker1.ValueChanged -= value;
        }

        public event EventHandler SellChange
        {
            add => btnChangeTL.Click += value;
            remove => btnChangeTL.Click -= value;
        }

        public event EventHandler SellDelete
        {
            add => btnDelTL.Click += value;
            remove => btnDelTL.Click -= value;
        }
    }
}
