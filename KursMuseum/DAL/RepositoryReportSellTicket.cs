using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.Model;

namespace KursMuseum.DAL
{
    public interface IRepositoryExcursion : IRepository<ReportSellTicket>
    {
        BindingList<ReportSellTicket> GetAll();
        BindingList<ReportSellTicket> Get();
    }
    public class RepositoryReportSellTicket : IRepositoryExcursion
    {
        private LocalStorage db;
        public RepositoryReportSellTicket(LocalStorage db)
        {
            this.db = db;
        }
        public BindingList<ReportSellTicket> GetAll()
        {
            return db.ReportSellTickets;
        }
        public void Create(ReportSellTicket excursion)
        {
            db.ReportSellTickets.Add(excursion);
        }
        public void Delete(ReportSellTicket excursion)
        {
        }
        public void Update(ReportSellTicket excursion)
        {
        }

        public BindingList<ReportSellTicket> Get()
        {
            throw new NotImplementedException();
        }
    }
}
