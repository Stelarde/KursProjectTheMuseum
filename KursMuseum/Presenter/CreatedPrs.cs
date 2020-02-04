using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.View;
using KursMuseum.DAL;
using KursMuseum.Model;
using System.ComponentModel;

namespace KursMuseum.Presenter
{
    public class CreatedPrs
    {
        ICreatedEx createdEx;
        ScheduleExcursionItem scheduleExcursionItem = new ScheduleExcursionItem();

        public CreatedPrs(ICreatedEx CE)
        {
            createdEx = CE;
            createdEx.Show();
            CE.addExcursion += addExcursionClick;            
        }

        private void addExcursionClick(object sender, EventArgs e)
        {
            scheduleExcursionItem.TypeExcursion = createdEx.NameExcursion;
            scheduleExcursionItem.TimeStart = createdEx.TimeStartExcursion;
            scheduleExcursionItem.TimeFinish = createdEx.TimeFinishExcursion;
            scheduleExcursionItem.Venue = createdEx.VenueExcursion;
            scheduleExcursionItem.TicketsLeft = createdEx.QuantityTicketsExcursion;
            scheduleExcursionItem.InitialCost = createdEx.StartPriceTicketExcursion;
            UnitOfWork unitOfWork = new UnitOfWork();
            unitOfWork.RepositoryScheduleExcursionItem.Create(scheduleExcursionItem);
            createdEx.Close();
        }
    }
}
