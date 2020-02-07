using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.View;
using KursMuseum.Model;
using KursMuseum.DAL;
using System.ComponentModel;

namespace KursMuseum.Presenter
{
    public class ChangeExPrs
    {
        IChangeEx changeEx;
        ScheduleExcursionItem scheduleExcursionItem = new ScheduleExcursionItem();
        BindingList<ScheduleExcursionItem> scheduleExcursionItems = new BindingList<ScheduleExcursionItem>();
        UnitOfWork UnitOfWork;
        public ChangeExPrs(IChangeEx ChEx, UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            changeEx = ChEx;
            scheduleExcursionItems = UnitOfWork.RepositoryScheduleExcursionItem.GetAll();
            changeEx.Excurs = scheduleExcursionItems;
            ChEx.ChangeExcursion += ChengeExcursionClick;
            ChEx.SelectExcurs += SelectExcursionClick;
            changeEx.ShowDialog();
        }

        private void SelectExcursionClick(object sender, EventArgs e)
        {
            scheduleExcursionItem.TypeExcursion = changeEx.SelectExcursItem.TypeExcursion;
            scheduleExcursionItem.Venue = changeEx.SelectExcursItem.Venue;
            scheduleExcursionItem.TimeStart = changeEx.SelectExcursItem.TimeStart;
            scheduleExcursionItem.TimeFinish = changeEx.SelectExcursItem.TimeFinish;
            scheduleExcursionItem.TicketsLeft = changeEx.SelectExcursItem.TicketsLeft;
            scheduleExcursionItem.InitialCost = changeEx.SelectExcursItem.InitialCost;
            changeEx.NameExcursion = scheduleExcursionItem.TypeExcursion;
            changeEx.TimeStartExcursion = scheduleExcursionItem.TimeStart;
            changeEx.TimeFinishExcursion = scheduleExcursionItem.TimeFinish;
            changeEx.VenueExcursion = scheduleExcursionItem.Venue;
            changeEx.QuantityTicketsExcursion = scheduleExcursionItem.TicketsLeft;
            changeEx.StartPriceTicketExcursion = scheduleExcursionItem.InitialCost;
        }

        private void ChengeExcursionClick(object sender, EventArgs e)
        {
            scheduleExcursionItem.TypeExcursion = changeEx.NameExcursion;
            scheduleExcursionItem.TimeStart = changeEx.TimeStartExcursion;
            scheduleExcursionItem.TimeFinish = changeEx.TimeFinishExcursion;
            scheduleExcursionItem.Venue = changeEx.VenueExcursion;
            scheduleExcursionItem.TicketsLeft = changeEx.QuantityTicketsExcursion;
            scheduleExcursionItem.InitialCost = changeEx.StartPriceTicketExcursion;
            UnitOfWork unitOfWork = new UnitOfWork();
            unitOfWork.RepositoryScheduleExcursionItem.Update(scheduleExcursionItem);
            changeEx.Close();
        }
    }
}