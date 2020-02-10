using MailSender.lib.Entities.Base;
using System.Collections.Generic;

namespace MailSender.lib.Entities
{
    /// <summary>
    /// Список рассылки писем
    /// </summary>
    public class MailingList : NamedEntity
    {
        /// <summary>
        /// Список получателей писем
        /// </summary>
        public ICollection<Recipient> Recipients { get; set; } = new List<Recipient>();
    }
}
