using MailSender.lib.Entities.Base;
using MailSender.lib.Services.Interfaces.Manager;
using MailSender.lib.Services.Interfaces.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Services.Managers
{
    public abstract class DataManager<T> : IDataManager<T> where T : BaseEntity
    {
        private IDataStore<T> _store;

        protected DataManager(IDataStore<T> store = null) => _store = store;

        public void Add(T item) => _store.Create(item);

        public void Edit(T item) => _store.Edit(item.Id, item);

        public IEnumerable<T> GetAll() => _store.GetAll();

        public void SaveChanges() => _store.SaveChanges();        
    }
}
