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

using KursMuseum.Export.Excel;

namespace KursMuseum.Presenter
{
    public class SellPrs
    {
        ISellForm _sellForm;
        UnitOfWork unitOfWork = new UnitOfWork();
        ExcelExport export = new ExcelExport();
        UnitOfWork UnitOfWork;
        public SellPrs(ISellForm RF, UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            _sellForm = RF;
            RF.SellTickets = UnitOfWork.RepositorySellTicket.GetAll();
            RF.SellDelete += SellDeleteClick;
            RF.SellChange += SellChangeClick;
            RF.ChangeDateSell += ChangeDateSellClick;
            RF.ReportSellTicket += ReportSellTicketClick;
            RF.AllSalles = UnitOfWork.RepositorySellTicket.SummSellTicket(_sellForm.SelectDate);
            _sellForm.ShowDialog();
        }

        private void ReportSellTicketClick(object sender, EventArgs e)
        {
            ReportSellTicket reportSellTicket = new ReportSellTicket();
            reportSellTicket.NameExcursion = _sellForm.NameExcrusion;
            reportSellTicket.TimeStart = _sellForm.TimeStart;
            reportSellTicket.Month = _sellForm.SelectDate;
            reportSellTicket.CountChildTickets = unitOfWork.RepositorySellTicket.CountSellTicket("Детский");
            reportSellTicket.PriceChildTickets = unitOfWork.RepositorySellTicket.SummSellTypeTicket("Детский");
            reportSellTicket.CountNormalTickets = unitOfWork.RepositorySellTicket.CountSellTicket("Обычный");
            reportSellTicket.PriceNormalTickets = unitOfWork.RepositorySellTicket.SummSellTypeTicket("Обычный");
            reportSellTicket.CountOldTickets = unitOfWork.RepositorySellTicket.CountSellTicket("Пенсионный");
            reportSellTicket.PriceOldTickets = unitOfWork.RepositorySellTicket.SummSellTypeTicket("Пенсионный");
            reportSellTicket.Summ = _sellForm.AllSalles;
            unitOfWork.RepositoryReportSellTicket.Create(reportSellTicket);

            export.SetContent(unitOfWork.RepositoryReportSellTicket);
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
            var rf = new ChangeSellPrs(new ChangeSell(), unitOfWork);
            _sellForm.SellTickets = null;
            _sellForm.SellTickets = UnitOfWork.RepositorySellTicket.GetAll();
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