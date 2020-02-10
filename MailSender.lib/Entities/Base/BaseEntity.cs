using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Entities.Base
{
    /// <summary>
    /// Базовое описание всех классов типа сущность
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Индетификатор (спец номер в БД)
        /// </summary>
        public int Id { get; set; }
    }
}
