using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Services
{
    public class SendersManager : ISendersManager
    {
        private ISendersStore _store;

        public SendersManager(ISendersStore store)
        {
            _store = store;
        }

        public void Add(Sender newSender)
        {
            
        }

        public void Edit(Sender sender)
        {
            
        }

        public IEnumerable<Sender> GetAll()
        {
            return _store.Get();
        }

        public void SaveChanges()
        {
            
        }
    }
}
