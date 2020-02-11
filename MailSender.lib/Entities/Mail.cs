using MailSender.lib.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Entities
{
    /// <summary>
    /// Тестирование особенностей pullRequest
    /// </summary>
    public class Mail : BaseEntity
    {
        /// <summary>
        /// Заголовок (тема) письма
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Основной текст письма
        /// </summary>
        public string Text { get; set; }
    }
}
