using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.Model
{
    public class ReportSellTicket
    {
        public string NameExcursion { get; set; }
        public DateTime TimeStart { get; set; }
        public double Summ { get; set; }
        public DateTime Month { get; set; }
        public int CountChildTickets { get; set; }
        public double PriceChildTickets { get; set; }
        public int CountNormalTickets { get; set; }
        public double PriceNormalTickets { get; set; }
        public int CountOldTickets { get; set; }
        public double PriceOldTickets { get; set; }
    }
}