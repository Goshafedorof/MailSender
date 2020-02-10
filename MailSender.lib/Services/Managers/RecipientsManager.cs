using MailSender.lib.Entities;
using MailSender.lib.Services.InMemory;
using MailSender.lib.Services.Interfaces.Manager;
using MailSender.lib.Services.Interfaces.Store;

namespace MailSender.lib.Services.Managers
{
    public class RecipientsManager : DataManager<Recipient>, IRecipientsManager 
    {
        public RecipientsManager(IRecipientsStore recipientsStore) : base(recipientsStore) { }
    }
}
