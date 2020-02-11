using MailSender.lib.Data;
using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces.Store;
using System;

namespace MailSender.lib.Services.InMemory
{
    /// <summary>
    /// Реализация хранения о получателях
    /// </summary>
    public class RecipientsStoreInMemory : DataStoreInMemory<Recipient>, IRecipientsStore
    {
        public RecipientsStoreInMemory() : base(TestData.Recipients) { }

        public override void Edit(int id, Recipient recipient)
        {
            if (id < 0 || recipient == null)
                throw new ArgumentNullException();

            var db_recipient = GetById(id);
            if (db_recipient is null) return;

            // Имитация работы не с объектами в памяти, а с объектам в БД
            db_recipient.Name = recipient.Name;       
            db_recipient.Address = recipient.Address;
        }
    }
}
