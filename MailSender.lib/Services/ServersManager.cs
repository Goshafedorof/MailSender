using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;

namespace MailSender.lib.Services
{
    public class ServersManager : IServersManager
    {
        private readonly IServersStore _store;

        public ServersManager(IServersStore store)
        {
            _store = store;
        }

        public void Add(Server newServer)
        {
            
        }

        public void Edit(Server server)
        {
            
        }

        public IEnumerable<Server> GetAll()
        {
            return _store.Get();
        }

        public void SaveChanges()
        {
            
        }
    }
}
