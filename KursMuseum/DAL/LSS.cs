using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.DAL
{
    
    public static class LSS
    {
        
        private static LocalStorage localStorage = new LocalStorage();
        // минимальная допустимая сумма для всех счетов
        public static LocalStorage LocalStorage
        {
            get { return localStorage; }
            set { localStorage = value; }
        }
    }
}
