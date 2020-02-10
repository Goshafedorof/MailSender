using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Entities
{
    /// <summary>
    /// Описание получателя писем
    /// </summary>
    public class Recipient
    {
        /// <summary>
        /// индетификатор получателя для дальнейшей раоты с БД
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя получателя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        public string Address { get; set; }
    }
}
