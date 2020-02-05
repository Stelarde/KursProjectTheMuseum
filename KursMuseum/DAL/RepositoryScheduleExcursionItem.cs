using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.Model;

namespace KursMuseum.DAL
{
    public interface IRepositoryScheduleExcursionItem : IRepository<ScheduleExcursionItem>
    {
        BindingList<ScheduleExcursionItem> GetAll();
    }
    public class RepositoryScheduleExcursionItem : IRepositoryScheduleExcursionItem
    {
        private LocalStorage db;
        public RepositoryScheduleExcursionItem(LocalStorage db)
        {
            this.db = db;
        }
        public BindingList<ScheduleExcursionItem> GetAll()
        {
            return db.ScheduleExcursionItems;
        }
        public ScheduleExcursionItem Get(string nameScheduleExcursionItem, DateTime dateTime)
        {
            BindingList<ScheduleExcursionItem> ScheduleExcursionItems = GetAll();
            foreach(ScheduleExcursionItem sheduleExcursionItem in ScheduleExcursionItems)
            {
                if ((nameScheduleExcursionItem == sheduleExcursionItem.TypeExcursion)
                    &&(dateTime== sheduleExcursionItem.TimeStart)) return sheduleExcursionItem;
            }
            return null;
        }
        public bool Check(string nameScheduleExcursionItem, DateTime dateTime)
        {
            BindingList<ScheduleExcursionItem> ScheduleExcursionItems = GetAll();
            foreach (ScheduleExcursionItem sheduleExcursionItem in ScheduleExcursionItems)
            {
                if ((nameScheduleExcursionItem == sheduleExcursionItem.TypeExcursion)
                    && (dateTime == sheduleExcursionItem.TimeStart)) return true;
            }
            return false;
        }
        public void Create(ScheduleExcursionItem scheduleExcursionItem)
        {
            if (!Check(scheduleExcursionItem.TypeExcursion, scheduleExcursionItem.TimeStart)) 
            { db.ScheduleExcursionItems.Add(scheduleExcursionItem); }
        }
        public void Delete(ScheduleExcursionItem scheduleExcursionItem)
        {
            if (Check(scheduleExcursionItem.TypeExcursion, scheduleExcursionItem.TimeStart))
            {
                db.ScheduleExcursionItems.Remove(
                    db.ScheduleExcursionItems.FirstOrDefault(
                    x => (x.TypeExcursion == scheduleExcursionItem.TypeExcursion)
                    &&(x.TimeStart== scheduleExcursionItem.TimeStart)));
            }
        }
        public void Update(ScheduleExcursionItem scheduleExcursionItem)
        {
            if (Check(scheduleExcursionItem.TypeExcursion, scheduleExcursionItem.TimeStart))
            {
                BindingList<ScheduleExcursionItem> ScheduleExcursionItems = GetAll();

                foreach (ScheduleExcursionItem item in ScheduleExcursionItems)
                {
                    if ((scheduleExcursionItem.TypeExcursion == item.TypeExcursion)
                     && (scheduleExcursionItem.TimeStart == item.TimeStart))
                    {
                        item.TypeExcursion = scheduleExcursionItem.TypeExcursion;
                        item.InitialCost = scheduleExcursionItem.InitialCost;
                        item.TicketsLeft = scheduleExcursionItem.TicketsLeft;
                        item.TimeStart = scheduleExcursionItem.TimeStart;
                        item.Venue = scheduleExcursionItem.Venue;
                        item.TimeFinish = scheduleExcursionItem.TimeFinish;
                    }
                }
            }
        }
    }
}
