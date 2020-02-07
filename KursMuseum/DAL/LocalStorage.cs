using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.Model;
using System.ComponentModel;

namespace KursMuseum.DAL
{
    public class LocalStorage
    {  
        public BindingList<SellTicket> SellTickets;
        public BindingList<TypeTicket> TypeTickets;
        public BindingList<ScheduleExcursionItem> ScheduleExcursionItems;
        public BindingList<ReportSellTicket> ReportSellTickets;
        public void FillReportSellTickets()
        {
            ReportSellTickets = new BindingList<ReportSellTicket>();
        }
        public void FillSellTickets()
        {
            SellTickets = new BindingList<SellTicket>();
        }
        public void FillTypeTickets()
        {
            TypeTickets = new BindingList<TypeTicket>()
            {
                new TypeTicket()
                {
                    SalesRatio = 1.1,
                    TicketName = "Детский",
                },
                new TypeTicket()
                {
                    SalesRatio = 1.3,
                    TicketName = "Обычный",
                },
                new TypeTicket()
                {
                    SalesRatio = 1.1,
                    TicketName = "Пенсионный",
                }
            };
        }
        public void FillScheduleExcursionItems()
        {
            ScheduleExcursionItems = new BindingList<ScheduleExcursionItem>()
            {
                new ScheduleExcursionItem()
                {
                    TypeExcursion="Дворцовые перевороты",
                    TimeFinish=DateTime.Now,
                    TimeStart=DateTime.Now,
                    Venue="Третий зал",
                    TicketsLeft=50,
                    InitialCost=300
                }
            };
        }
        public LocalStorage()
        {
            FillSellTickets();
            FillTypeTickets();
            FillScheduleExcursionItems();
            FillReportSellTickets();
        }
    }
}