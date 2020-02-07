using MailSender.lib.Data;
using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Services
{
    public class ServerStoreInMemory : IServersStore
    {
        public void Add(Server server)
        {
            
        }

        public void Edit(int id, Server server)
        {
            
        }

        public IEnumerable<Server> Get()
        {
            return TestData.Servers;
        }

        public void SaveChanges()
        {
            
        }
    }
}
