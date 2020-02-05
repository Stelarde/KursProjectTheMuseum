using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.Model
{
    public class SellTicket
    {
        [DisplayName("Название экскурсии")]
        //Название экскурсии
        public string NameExcursion { get; set; }
        [DisplayName("Время начала экскурсии")]
        //Время начала экскурсии
        public DateTime TimeStart { get; set; }
        [DisplayName("Тип билета")]
        //Тип билета
        public string TypeTicket { get; set; }
        [DisplayName("Цена билета")]
        //Цена
        public double PriceTicket { get; set; }
        [DisplayName("Время продажи билета")]
        //Время продажи билета    
        public DateTime SellTime { get; set; }
        public override string ToString()
        {
            return NameExcursion + " " + SellTime.ToString();
        }
    }
}