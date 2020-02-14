using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces.Manager;
using MailSender.lib.Services.Interfaces.Store;

namespace MailSender.lib.Services.Managers
{
    public class ServersManager : DataManager<Server>, IServersManager
    {
        public ServersManager(IServersStore serversStore) : base(serversStore) { }
    }
}
