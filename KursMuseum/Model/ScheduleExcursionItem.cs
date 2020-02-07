using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.Model
{
    public class ScheduleExcursionItem
    {
        [DisplayName("Название экскурсии")]
        //Название экскурсии     
        public string TypeExcursion { get; set; }
        [DisplayName("Дата и время начала экскурсии")]
        //Время начала экскурсии
        public DateTime TimeStart { get; set; }
        [DisplayName("Дата и время конца экскурсии")]
        //Время конца экскурсии
        public DateTime TimeFinish { get; set; }
        [DisplayName("Место сбора поситителей")]
        //Место сбора поситителей
        public string Venue { get; set; } 
        [DisplayName("Осталось билетов")]
        //Остаток билетов
        public int TicketsLeft { get; set; }
        [DisplayName("Начальная стоимость")]
        //Начальная стоимость билета
        public double InitialCost { get; set; }
        public override string ToString()
        {
            return TypeExcursion +" "+ TimeStart.ToString();
        }
        
    }
}