using MailSender.lib.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Entities
{
    /// <summary>
    /// Планировщик задач
    /// </summary>
    public class SchedulerTask : BaseEntity
    {
        /// <summary>
        /// Время выполнения задания
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Отправитель почты в задании
        /// </summary>
        public Sender Sender { get; set; }

        /// <summary>
        /// Список получателей писем
        /// </summary>
        public MailingList Recipients { get; set; }

        /// <summary>
        /// Сервер, через который надо выполнить отправку почты
        /// </summary>
        public Server Server { get; set; }

        /// <summary>
        /// Письмо, которое требуется разослать
        /// </summary>
        public Mail Mail { get; set; }
    }
}
