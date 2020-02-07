using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.DAL;
using KursMuseum.Model;
using KursMuseum.View;
using System.Windows.Forms;
using KursMuseum.Export.Excel;

namespace KursMuseum.Presenter
{
    public class MainPresenter : IMainPresenter
    {
        private IMainForm _mainView { get; set; }
        private double PriceTicket;
        ExcelExportShedule export = new ExcelExportShedule();

        public void Run()
        {
            _mainView.Show();            
        }
        UnitOfWork UnitOfWork;
        public MainPresenter (IMainForm view, UnitOfWork unitOfWork, LocalStorage db)
        {
            UnitOfWork = unitOfWork;
            _mainView = view;
            view.AddEx += AddExClick;
            view.SoldTickets += SoldTicketsClick;
            view.SelectedTypeTicket += TypeTicketChanged;
            view.MainTable += ExcursionChoice;
            view.ChangeEx += ChangeExcursion;
            view.DeleteEx += DeleteExcursion;
            view.SellTicket += SellTicketClick;
            view.CloseProgram += CloseProgramClick;
            view.ReportShedule += ReportSheduleClick;

            BindingList<string> TypeTickets = new BindingList<string> 
            {
                db.TypeTickets[0].TicketName, 
                db.TypeTickets[1].TicketName, 
                db.TypeTickets[2].TicketName
            };
            view.TypeTickets = TypeTickets;
            view.ScheduleExcursionItems = UnitOfWork.RepositoryScheduleExcursionItem.GetAll();
        }

        private void ReportSheduleClick(object sender, EventArgs e)
        {
            export.SetContent(UnitOfWork.RepositoryScheduleExcursionItem);
        }

        private void CloseProgramClick(object sender, EventArgs e)
        {
            _mainView.Close();
        }

        private void SellTicketClick(object sender, EventArgs e)
        {
            SellTicket sellTicket = new SellTicket();
            ScheduleExcursionItem scheduleExcursionItem = new ScheduleExcursionItem();
            sellTicket.NameExcursion = _mainView.SelectMainTableTypeExcursion;
            sellTicket.PriceTicket = _mainView.PriceTickets;
            sellTicket.SellTime = DateTime.Now;
            sellTicket.TimeStart = _mainView.SelectMainTableTimeStart;
            sellTicket.TypeTicket = _mainView.TypeTicket;
            UnitOfWork.RepositorySellTicket.Create(sellTicket);
            scheduleExcursionItem.TicketsLeft = _mainView.SelectMainTableTicketLeft - 1;
            scheduleExcursionItem.InitialCost = _mainView.SelectMainTableInitialCost;
            scheduleExcursionItem.TimeFinish = _mainView.SelectMainTableTimeFinish;
            scheduleExcursionItem.TimeStart = _mainView.SelectMainTableTimeStart;
            scheduleExcursionItem.TypeExcursion = _mainView.SelectMainTableTypeExcursion;
            scheduleExcursionItem.Venue = _mainView.SelectMainTableVenue;
            UnitOfWork.RepositoryScheduleExcursionItem.Update(scheduleExcursionItem);
            MessageBox.Show("Билет продан на '" + sellTicket.NameExcursion + "' " + sellTicket.TypeTicket + " по цене "+ sellTicket.PriceTicket.ToString());
        }

        private void DeleteExcursion(object sender, EventArgs e)
        {
            ScheduleExcursionItem scheduleExcursionItem = new ScheduleExcursionItem();
            scheduleExcursionItem.InitialCost = _mainView.SelectMainTableInitialCost;
            scheduleExcursionItem.TicketsLeft = _mainView.SelectMainTableTicketLeft;
            scheduleExcursionItem.TimeFinish = _mainView.SelectMainTableTimeFinish;
            scheduleExcursionItem.TimeStart = _mainView.SelectMainTableTimeStart;
            scheduleExcursionItem.TypeExcursion = _mainView.SelectMainTableTypeExcursion;
            scheduleExcursionItem.Venue = _mainView.SelectMainTableVenue;
            UnitOfWork.RepositoryScheduleExcursionItem.Delete(scheduleExcursionItem);
        }

        private void ChangeExcursion(object sender, EventArgs e)
        {
            var rf = new ChangeExPrs(new ChangeEx(), UnitOfWork);
            _mainView.ScheduleExcursionItems = null;
            _mainView.ScheduleExcursionItems = UnitOfWork.RepositoryScheduleExcursionItem.GetAll();
        }

        private void ExcursionChoice(object sender, EventArgs e)
        {
            PriceTicket = _mainView.SelectMainTableInitialCost;
        }

        private void TypeTicketChanged(object sender, EventArgs e)
        {
            if (_mainView.SelectTypeTckets == 0 | _mainView.SelectTypeTckets == 2)
            {
                _mainView.PriceTickets = PriceTicket * 1.1;
            }
            else
            {
                _mainView.PriceTickets = PriceTicket * 1.3;
            }
        }

        private void AddExClick(object sender, EventArgs e)
        {
            var rf = new CreatedPrs(new CreatedEx(), UnitOfWork);
        }
        private void SoldTicketsClick(object sender, EventArgs e)
        {
            var sf = new SellPrs(new SellForm(), UnitOfWork);
        }
    }
}