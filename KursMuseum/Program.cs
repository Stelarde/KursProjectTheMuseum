using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KursMuseum.Presenter;
using KursMuseum.View;

namespace KursMuseum
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var presenter = new MainPresenter(new MainForm(), new DAL.UnitOfWork(), new DAL.LocalStorage());
            presenter.Run();
        }
    }
}
