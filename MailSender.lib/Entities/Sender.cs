using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Entities
{
    /// <summary>
    /// Описатель отправителя
    /// </summary>
    public class Sender
    {
        /// <summary>
        /// Индитификационный номер отправителя
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя отправителя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Адрес электронной почты отправителя
        /// </summary>
        public string Address { get; set; }

        public override string ToString() => $"{Name} :: {Address}";
    }
}
