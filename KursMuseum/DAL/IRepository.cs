using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.DAL
{
    public interface IRepository<T> where T : class
    {
        BindingList<T> GetAll();
        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}
