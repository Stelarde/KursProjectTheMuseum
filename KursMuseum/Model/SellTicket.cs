using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.Model
{
    public class SellTicket
    {
        //Номер билета
        public string idTicket { get; set; }
        //Время начала экскурсии
        public DateTime TimeStart { get; set; }
        //Тип билета
        public TypeTicket TypeTicket { get; set; }
        //Цена
        public double PriceTicket { get; set; }
        //Время продажи билета    
        public DateTime SellTime { get; set; }
    }
}