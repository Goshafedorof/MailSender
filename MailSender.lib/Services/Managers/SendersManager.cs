using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;
using MailSender.lib.Services.Interfaces.Manager;

namespace MailSender.lib.Services.Managers
{
    public class SendersManager : DataManager<Sender>, ISendersManager
    {
        public SendersManager(ISendersStore sendersStore) : base(sendersStore) { }
    }
}
