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
    public partial class ChangeSell : Form, IChangeSell
    {
        public ChangeSell()
        {
            InitializeComponent();
        }

        public string NameExcrusion 
        { 
            get => tbNameExcurs.Text; 
            set => tbNameExcurs.Text = value; 
        }
        public DateTime TimeStart 
        { 
            get => dtpTimeStartExcurs.Value; 
            set => dtpTimeStartExcurs.Value = value; 
        }
        public string TypeTicket 
        { 
            get => tbTypeTicket.Text; 
            set => tbTypeTicket.Text = value; 
        }
        public double PriceTicket 
        {
            get => double.Parse(tbPriceTicket.Text); 
            set => tbPriceTicket.Text = Convert.ToString(value); 
        }
        public DateTime SellTime 
        { 
            get => dtpTimeSellTicket.Value; 
            set => dtpTimeSellTicket.Value= value; 
        }
        public BindingList<SellTicket> Sell 
        { 
            set => cbSell.DataSource = value;
        }

        public SellTicket SelectSellTicket => (SellTicket)cbSell.SelectedItem;

        public event EventHandler ChangeSel
        {
            add => button1.Click += value;
            remove => button1.Click -= value;
        }
        public event EventHandler SelectSel
        {
            add => cbSell.SelectedIndexChanged += value;
            remove => cbSell.SelectedIndexChanged -= value;
        }
    }
}
