using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.lib.Entities;


namespace MailSender.lib.Services.Interfaces.Store
{
    /// <summary>
    /// Хранидище данных о получателях
    /// </summary>
    public interface IRecipientsStore : IDataStore<Recipient> { }
}
