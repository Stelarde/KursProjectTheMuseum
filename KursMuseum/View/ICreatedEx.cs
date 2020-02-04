using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.Model;

namespace KursMuseum.View
{
    public interface ICreatedEx : IView
    {
        string NameExcursion { get; }
        DateTime TimeStartExcursion { get; }
        DateTime TimeFinishExcursion { get; }
        string VenueExcursion { get; }
        int QuantityTicketsExcursion { get; }
        double StartPriceTicketExcursion { get; }
        event EventHandler addExcursion;
    }
}
