using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Services.Interfaces
{
    /// <summary>
    /// Хранилище отправителей
    /// </summary>
    public interface ISendersStore : IDataStore<Sender> { }
}
