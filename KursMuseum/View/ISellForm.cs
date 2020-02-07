using KursMuseum.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.View
{
    public interface ISellForm : IView
    {
        BindingList<SellTicket> SellTickets { get; set; }
        string NameExcrusion { get; }
        DateTime TimeStart { get; }
        string TypeTicket { get; }
        double PriceTicket { get; }
        DateTime SellTime { get; }
        double AllSalles { get; set; }
        DateTime SelectDate { get; }
        event EventHandler SellDelete;
        event EventHandler SellChange;
        event EventHandler ChangeDateSell;
        event EventHandler ReportSellTicket;
    }
}
