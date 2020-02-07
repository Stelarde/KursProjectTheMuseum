using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.DAL
{
    public class UnitOfWork
    {
        private LocalStorage db = LSS.LocalStorage;
        private RepositoryScheduleExcursionItem repositoryScheduleExcursionItem;
        private RepositorySellTicket repositorySellTicket;
        private RepositoryReportSellTicket repositoryReportSellTicket;
        public RepositoryScheduleExcursionItem RepositoryScheduleExcursionItem
        {
            get
            {
                if (repositoryScheduleExcursionItem == null)
                    repositoryScheduleExcursionItem = new RepositoryScheduleExcursionItem(db);
                return repositoryScheduleExcursionItem;
            }
        }
        public RepositorySellTicket RepositorySellTicket
        {
            get
            {
                if (repositorySellTicket == null)
                    repositorySellTicket = new RepositorySellTicket(db);
                return repositorySellTicket;
            }
        }
        public RepositoryReportSellTicket RepositoryReportSellTicket
        {
            get
            {
                if (repositoryReportSellTicket == null)
                    repositoryReportSellTicket = new RepositoryReportSellTicket(db);
                return repositoryReportSellTicket;
            }
        }
    }
}
