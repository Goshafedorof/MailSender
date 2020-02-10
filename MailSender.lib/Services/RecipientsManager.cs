using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;

namespace MailSender.lib.Services
{
    public class RecipientsManager : IRecipientsManager
    {
        /// <summary>
        /// Способ хранения данных
        /// </summary>
        private IRecipientsStore _store;

        public RecipientsManager(IRecipientsStore store) => _store = store;

        public void Add(Recipient newRecipient)
        {
            _store.Add(newRecipient);
        }

        public void Edit(Recipient recipient)
        {
            _store.Edit(recipient.Id, recipient);
        }

        public IEnumerable<Recipient> GetAll()
        {
            return _store.Get();
        }

        public void SaveChanges()
        {
            _store.SaveChanges();
        }
    }
}
