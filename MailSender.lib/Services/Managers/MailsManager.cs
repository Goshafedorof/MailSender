using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces.Manager;
using MailSender.lib.Services.Interfaces.Store;

namespace MailSender.lib.Services.Managers
{
    public class MailsManager : DataManager<Mail>, IMailsManager
    {
        public MailsManager(IMailsStore mailsStore) : base(mailsStore) { }
    }
}
