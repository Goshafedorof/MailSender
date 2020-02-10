using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;
using MailSender.lib.Data;

namespace MailSender.lib.Services
{
    public class RecipientsStoreInMemory : IRecipientsStore
    {
        public IEnumerable<Recipient> Get() => TestData.Recipients;

        public void Add(Recipient recipient)
        {
            
        }

        public void Edit(int id, Recipient recipient)
        {
            
        }

        public void SaveChanges()
        {
            
        }
    }
}
