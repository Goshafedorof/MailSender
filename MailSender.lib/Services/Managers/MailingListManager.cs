using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces.Manager;
using MailSender.lib.Services.Interfaces.Store;

namespace MailSender.lib.Services.Managers
{
    public class MailingListManager : DataManager<MailingList>, IMailingListManager
    {
        public MailingListManager(IMailingListStore mailingListStore) : base(mailingListStore) { }
    }
}
