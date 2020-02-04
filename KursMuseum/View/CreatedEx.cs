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
    public partial class CreatedEx : Form, ICreatedEx
    {
        public CreatedEx()
        {
            InitializeComponent();
        }

        public string NameExcursion => NameEx.Text;

        public DateTime TimeStartExcursion => DateTimeStartEx.Value;

        public DateTime TimeFinishExcursion => DateTimeFinishEx.Value;

        public string VenueExcursion => tbVenue.Text;

        public int QuantityTicketsExcursion => Convert.ToInt32(tbQuantityTickets.Text);

        public double StartPriceTicketExcursion => double.Parse(tbStartPrice.Text);

        public event EventHandler addExcursion
        {
            add => button1.Click += value;
            remove => button1.Click -= value;
        }
    }
}
