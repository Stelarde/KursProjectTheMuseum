using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.Model;

namespace KursMuseum.View
{
    public interface IChangeEx : IView
    {
        string NameExcursion { get; set; }
        DateTime TimeStartExcursion { get; set; }
        DateTime TimeFinishExcursion { get; set; }
        string VenueExcursion { get; set; }
        int QuantityTicketsExcursion { get; set; }
        double StartPriceTicketExcursion { get; set; }
        BindingList<ScheduleExcursionItem> Excurs { set; }
        ScheduleExcursionItem SelectExcursItem { get; }
        event EventHandler ChangeExcursion;
        event EventHandler SelectExcurs;
    }
}
