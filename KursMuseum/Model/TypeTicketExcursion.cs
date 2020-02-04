using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.Model
{
    public class TypeTicketExcursion
    {    
        //Список типов билетов
        public List<TypeTicket> TypeTickets = new List<TypeTicket>(); 
        //Список экскурсий
        public List<ScheduleExcursionItem> ScheduleExcursionItems = new List<ScheduleExcursionItem>();

        //public TypeTicket TypeTicket { get; set; }
        //public ScheduleExcurceItem ScheduleExcurceItem { get; set; }   
        //public double price { get; set; }
    }
}