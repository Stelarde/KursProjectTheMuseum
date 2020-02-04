using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.DAL;
using KursMuseum.View;

namespace KursMuseum.Presenter
{
    public class SellPrs
    {
        ISellForm sellForm;
        public SellPrs(ISellForm RF, LocalStorage db)
        {
            sellForm = RF;
            sellForm.Show();
            sellForm.SellTickets = db.SellTickets;
        }
        private void AddExClick(object sender, EventArgs e)
        {
            var ex = new CreatedPrs(new CreatedEx());
        }
    }   
}