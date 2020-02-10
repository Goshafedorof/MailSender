using MailSender.lib.Data;
using MailSender.lib.Entities;

namespace MailSender.lib.Services.Interfaces.Store.InMemory
{
    public class SendersStoreInMemory : DataStoreInMemory<Sender>, ISendersStore
    {
        public SendersStoreInMemory() : base(TestData.Senders) { }

        public override void Edit(int id, Sender sender)
        {
            var db_sender = GetById(id);
            if (db_sender is null) return;

            // Имитация работы не с объектами в памяти, а с объектам в БД
            db_sender.Name = sender.Name;
            db_sender.Address = sender.Address;
        }
    }
}
