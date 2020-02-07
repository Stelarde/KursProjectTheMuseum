using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.View;
using KursMuseum.Model;
using KursMuseum.DAL;
using System.ComponentModel;

namespace KursMuseum.Presenter
{
    public class ChangeSellPrs
    {
        IChangeSell changeSell;
        SellTicket sellTicket = new SellTicket();
        BindingList<SellTicket> sellTickets = new BindingList<SellTicket>();
        UnitOfWork UnitOfWork;
        public ChangeSellPrs(IChangeSell ChSel, UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            changeSell = ChSel;
            sellTickets = UnitOfWork.RepositorySellTicket.GetAll();
            changeSell.Sell = sellTickets;            
            ChSel.SelectSel += SelectSelClick;
            ChSel.ChangeSel += ChangeSelClick;
            changeSell.ShowDialog();
        }

        private void ChangeSelClick(object sender, EventArgs e)
        {
            sellTicket.NameExcursion = changeSell.NameExcrusion;
            sellTicket.PriceTicket = changeSell.PriceTicket;
            sellTicket.SellTime = changeSell.SellTime;
            sellTicket.TimeStart = changeSell.TimeStart;
            sellTicket.TypeTicket = changeSell.TypeTicket;
            UnitOfWork unitOfWork = new UnitOfWork();
            unitOfWork.RepositorySellTicket.Update(sellTicket);
            changeSell.Close();
        }

        private void SelectSelClick(object sender, EventArgs e)
        {
            sellTicket.NameExcursion = changeSell.SelectSellTicket.NameExcursion;
            sellTicket.PriceTicket = changeSell.SelectSellTicket.PriceTicket;
            sellTicket.SellTime = changeSell.SelectSellTicket.SellTime;
            sellTicket.TimeStart = changeSell.SelectSellTicket.TimeStart;
            sellTicket.TypeTicket = changeSell.SelectSellTicket.TypeTicket;
            changeSell.NameExcrusion = sellTicket.NameExcursion;
            changeSell.PriceTicket = sellTicket.PriceTicket;
            changeSell.SellTime = sellTicket.SellTime;
            changeSell.TimeStart = sellTicket.TimeStart;
            changeSell.TypeTicket = sellTicket.TypeTicket;
        }
    }
}
