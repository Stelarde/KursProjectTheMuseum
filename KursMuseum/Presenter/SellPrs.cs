using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KursMuseum.DAL;
using KursMuseum.Model;
using KursMuseum.View;

namespace KursMuseum.Presenter
{
    public class SellPrs
    {
        ISellForm _sellForm;
        UnitOfWork unitOfWork = new UnitOfWork();
        public SellPrs(ISellForm RF)
        {
            _sellForm = RF;
            _sellForm.Show();
            RF.SellTickets = unitOfWork.RepositorySellTicket.GetAll();
            RF.SellDelete += SellDeleteClick;
            RF.SellChange += SellChangeClick;
            RF.ChangeDateSell += ChangeDateSellClick;
            RF.AllSalles = unitOfWork.RepositorySellTicket.SummSellTicket(_sellForm.SelectDate);
        }

        private void ChangeDateSellClick(object sender, EventArgs e)
        {
            BindingList<SellTicket> tickets = unitOfWork.RepositorySellTicket.GetAllDate(_sellForm.SelectDate);
            _sellForm.SellTickets = tickets;
            double sum = unitOfWork.RepositorySellTicket.SummSellTicket(_sellForm.SelectDate);
            _sellForm.AllSalles = sum;
        }

        private void SellChangeClick(object sender, EventArgs e)
        {
            var rf = new ChangeSellPrs(new ChangeSell());
        }

        private void SellDeleteClick(object sender, EventArgs e)
        {
            SellTicket sellTicket = new SellTicket();
            sellTicket.NameExcursion = _sellForm.NameExcrusion;
            sellTicket.PriceTicket = _sellForm.PriceTicket;
            sellTicket.SellTime = _sellForm.SellTime;
            sellTicket.TimeStart = _sellForm.TimeStart;
            sellTicket.TypeTicket = _sellForm.TypeTicket;
            unitOfWork.RepositorySellTicket.Delete(sellTicket);
            BindingList<SellTicket> tickets = unitOfWork.RepositorySellTicket.GetAllDate(_sellForm.SelectDate);
            _sellForm.SellTickets = tickets;
            _sellForm.AllSalles = unitOfWork.RepositorySellTicket.SummSellTicket(_sellForm.SelectDate);
        }
    }   
}