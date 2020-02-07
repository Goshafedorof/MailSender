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
    public class SenderStoreInMemory : ISendersStore
    {
        public void Add(Sender sender)
        {
            
        }

        public void Edit(int id, Sender sender)
        {
            
        }

        public IEnumerable<Sender> Get()
        {
            return TestData.Senders;
        }

        public void SaveChanges()
        {
            
        }
    }
}
