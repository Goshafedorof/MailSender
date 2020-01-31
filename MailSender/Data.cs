using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    public static class Data
    {
        /// <summary>
        /// SMTP - адрес сервера Yandex
        /// </summary>
        public const string SMTP_YANDEX = "smtp.yadex.ru";
        /// <summary>
        /// SMTP - адрес сервера Mail.Ru
        /// </summary>
        public const string SMTP_MAIL = "smtp.mail.ru";
        /// <summary>
        /// SMTP - порт (почти у всех одинаковый)
        /// </summary>
        public const int SMTP_PORT = 25;

        public const string OUTGOING_MAIL = "goshafedorof@mail.ru";

        /// <summary>
        /// Список email'ов кому мы отправляем письмо
        /// </summary>
        public static List<string> Mails = new List<string> { "g0shafedorof@yandex.ru" };

    }
}
