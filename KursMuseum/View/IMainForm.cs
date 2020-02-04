using KursMuseum.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.View
{
    public interface IMainForm : IView
    {
        double PriceTickets { get; set; }
        BindingList<ScheduleExcursionItem> ScheduleExcursionItems { get; set; }
        BindingList<string> TypeTickets { set; }
        int SelectTypeTckets { get; }
        double SelectMainTable { get; }
        event EventHandler AddEx;
        event EventHandler SoldTickets;
        event EventHandler TypeTicket;
        event EventHandler MainTable;
        event EventHandler ChangeEx;
    }
}
