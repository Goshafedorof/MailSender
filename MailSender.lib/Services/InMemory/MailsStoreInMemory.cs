using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces.Store;

namespace MailSender.lib.Services.InMemory
{
    public class MailsStoreInMemory : DataStoreInMemory<Mail>, IMailsStore
    {
        public MailsStoreInMemory() : base(null) { }

        public override void Edit(int id, Mail item)
        {
            throw new System.NotImplementedException();
        }
    }

}
