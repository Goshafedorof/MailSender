using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces.Store;

namespace MailSender.lib.Services.InMemory
{
    public class MailingListStoreInMemory : DataStoreInMemory<MailingList>, IMailingListStore
    {
        public MailingListStoreInMemory() : base(null) { }

        public override void Edit(int id, MailingList item)
        {
            throw new System.NotImplementedException();
        }
    }

}
