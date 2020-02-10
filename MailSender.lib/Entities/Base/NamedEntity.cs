using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Entities.Base
{
    /// <summary>
    /// Именованная сущность
    /// </summary>
    public abstract class NamedEntity : BaseEntity
    {
        /// <summary>
        /// Имя сущности
        /// </summary>
        public virtual string Name { get; set; }
    }
}
