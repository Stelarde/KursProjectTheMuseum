using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.Model;

namespace KursMuseum.View
{
    public interface IChangeSell : IView
    {
        string NameExcrusion { get; set; }
        DateTime TimeStart { get; set; }
        string TypeTicket { get; set; }
        double PriceTicket { get; set; }
        DateTime SellTime { get; set; }
        BindingList<SellTicket> Sell { set; }
        SellTicket SelectSellTicket { get; }
        event EventHandler ChangeSel;
        event EventHandler SelectSel;
    }
}
