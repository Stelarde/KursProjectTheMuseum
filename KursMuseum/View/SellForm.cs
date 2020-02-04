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
    }
}
