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
        public RepositoryScheduleExcursionItem RepositoryScheduleExcursionItem
        {
            get
            {
                if (repositoryScheduleExcursionItem == null)
                    repositoryScheduleExcursionItem = new RepositoryScheduleExcursionItem(db);
                return repositoryScheduleExcursionItem;
            }
        }
    }
}
