using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Entities.Base
{
    /// <summary>
    /// Персонофицированная сущность
    /// </summary>
    public abstract class PersonEntity : NamedEntity
    {
        /// <summary>
        /// Адрес (в контесте программы - email)
        /// </summary>
        public string Address { get; set; }
    }
}
