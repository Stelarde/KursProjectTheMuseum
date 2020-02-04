using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.DAL;
using KursMuseum.Model;
using KursMuseum.View;

namespace KursMuseum.Presenter
{
    public class MainPresenter : IMainPresenter
    {
        private IMainForm _mainView { get; set; }
        private double PriceTicket;

        public void Run()
        {
            _mainView.Show();            
        }
        UnitOfWork unitOfWork = new UnitOfWork();

        public void Update(IMainForm view)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            view.ScheduleExcursionItems = unitOfWork.RepositoryScheduleExcursionItem.GetAll();
        }
        public MainPresenter (IMainForm view, LocalStorage db)
        {
            _mainView = view;
            view.AddEx += AddExClick;
            view.SoldTickets += SoldTicketsClick;
            view.TypeTicket += TypeTicketChanged;
            view.MainTable += ExcursionChoice;
            view.ChangeEx += ChangeExcrusion;

            BindingList<string> TypeTicket = new BindingList<string> 
            {
                db.TypeTickets[0].TicketName, 
                db.TypeTickets[1].TicketName, 
                db.TypeTickets[2].TicketName
            };
            view.ScheduleExcursionItems = unitOfWork.RepositoryScheduleExcursionItem.GetAll();
        }

        private void ChangeExcrusion(object sender, EventArgs e)
        {
            var rf = new ChangeExPrs(new ChangeEx());

        }

        private void ExcursionChoice(object sender, EventArgs e)
        {
            PriceTicket = _mainView.SelectMainTable;
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
            var rf = new CreatedPrs(new CreatedEx());
        }
        private void SoldTicketsClick(object sender, EventArgs e)
        {
            var sf = new SellPrs(new SellForm(), new DAL.LocalStorage());
        }
    }
}