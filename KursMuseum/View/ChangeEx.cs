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
    public partial class ChangeEx : Form, IChangeEx
    {
        public ChangeEx()
        {
            InitializeComponent();
        }

        public string NameExcursion 
        { 
            get => tbNameEx.Text; 
            set => tbNameEx.Text = value; 
        }
        public DateTime TimeStartExcursion 
        { 
            get => DateTimeStartEx.Value; 
            set => DateTimeStartEx.Value = value; 
        }
        public DateTime TimeFinishExcursion 
        { 
            get => DateTimeFinishEx.Value; 
            set => DateTimeFinishEx.Value = value; 
        }
        public string VenueExcursion 
        { 
            get => tbVenue.Text; 
            set => tbVenue.Text = value; 
        }
        public int QuantityTicketsExcursion 
        { 
            get => Convert.ToInt32(tbQuantityTickets.Text); 
            set => tbQuantityTickets.Text = Convert.ToString(value); 
        }
        public double StartPriceTicketExcursion 
        {
            get => double.Parse(tbStartPrice.Text);
            set => tbStartPrice.Text = Convert.ToString(value); 
        }
        public BindingList<ScheduleExcursionItem> Excurs 
        { 
            set => cmbExcurs.DataSource = value;
        }

        public ScheduleExcursionItem SelectExcursItem => (ScheduleExcursionItem)cmbExcurs.SelectedItem;

        public event EventHandler SelectExcurs
        {
            add => cmbExcurs.SelectedIndexChanged += value;
            remove => cmbExcurs.SelectedIndexChanged -= value;
        }

        public event EventHandler ChangeExcursion
        {
            add => button1.Click += value;
            remove => button1.Click -= value;
        }
    }
}
