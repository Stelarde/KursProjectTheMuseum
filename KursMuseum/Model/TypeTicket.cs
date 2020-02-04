using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.Model
{
    public class TypeTicket
    {
        //Коэффициент от типа билета
        public double SalesRatio { get; set; }
        //Название билета
        public string TicketName { get; set; }
    }
}