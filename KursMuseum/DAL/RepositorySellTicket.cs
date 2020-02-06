using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.Model;
using System.ComponentModel;


namespace KursMuseum.DAL
{
    public interface IRepositorySellTicket : IRepository<SellTicket>
    {
        BindingList<SellTicket> GetAll();
    }
    public class RepositorySellTicket : IRepositorySellTicket
    {
        private LocalStorage db;
        public RepositorySellTicket(LocalStorage db)
        {
            this.db = db;
        }
        public BindingList<SellTicket> GetAll()
        {
            return db.SellTickets;
        }
        public double SummSellTicket(DateTime dateTime)
        {
            BindingList<SellTicket> summsellTickets = GetAllDate(dateTime);
            double sum = 0;
            foreach (SellTicket sellTicket in summsellTickets)
            {
                sum += sellTicket.PriceTicket;
            }
            return sum;
        }
        public BindingList<SellTicket> GetAllDate(DateTime dateTime)
        {
            BindingList<SellTicket> sellTicketsAll = db.SellTickets;
            var test =  sellTicketsAll.Where(x => x.SellTime.Date == dateTime.Date);
            BindingList<SellTicket> sellTicketsDate = new BindingList<SellTicket>();
            foreach(SellTicket sellTicket in test)
            {
                sellTicketsDate.Add(sellTicket);
            }
            return sellTicketsDate;
        }
        public SellTicket Get(string nameSellTicket, DateTime dateTime)
        {
            BindingList<SellTicket> SellTickets = GetAll();
            foreach (SellTicket sellTicket in SellTickets)
            {
                if ((nameSellTicket == sellTicket.NameExcursion)
                    && (dateTime == sellTicket.SellTime)) return sellTicket;
            }
            return null;
        }
        public bool Check(string nameSellTicket, DateTime dateTime)
        {
            BindingList<SellTicket> SellTickets = GetAll();
            foreach (SellTicket sellTicket in SellTickets)
            {
                if ((nameSellTicket == sellTicket.NameExcursion)
                    && (dateTime == sellTicket.SellTime)) return true;
            }
            return false;
        }
        public void Create(SellTicket sellTicket)
        {
            if (!Check(sellTicket.NameExcursion, sellTicket.SellTime))
            { db.SellTickets.Add(sellTicket); }
        }
        public void Delete(SellTicket sellTicket)
        {
            if (Check(sellTicket.NameExcursion, sellTicket.SellTime))
            {
                db.SellTickets.Remove(
                    db.SellTickets.FirstOrDefault(
                    x => (x.NameExcursion == sellTicket.NameExcursion)
                    && (x.SellTime == sellTicket.SellTime)));
            }
        }
        public void Update(SellTicket sellTicket)
        {
            if (Check(sellTicket.NameExcursion, sellTicket.SellTime))
            {
                BindingList<SellTicket> SellTickets = GetAll();

                foreach (SellTicket item in SellTickets)
                {
                    if ((sellTicket.NameExcursion == item.NameExcursion)
                     && (sellTicket.SellTime == item.SellTime))
                    {
                        item.NameExcursion = sellTicket.NameExcursion;
                        item.PriceTicket = sellTicket.PriceTicket;
                        item.SellTime = sellTicket.SellTime;
                        item.TimeStart = sellTicket.TimeStart;
                        item.TypeTicket = sellTicket.TypeTicket;
                    }
                }
            }
        }
    }
}
