using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace MailSender
{
    public class EmailSendService
    {
        /// <summary>
        /// Адрес SMTP сервера
        /// </summary>
        public string SmtpAddress { get; private set; }
        /// <summary>
        /// SMTP порт
        /// </summary>
        public int SmtpPort { get; private set; }
        /// <summary>
        /// Адрес исходящей почты
        /// </summary>
        public string OutgoingMail { get; private set; }
        /// <summary>
        /// Пароль исходящей почты
        /// </summary>
        public string OutgoingMailPassword { get; private set; }

        /// <summary>
        /// Сервис отправки сообщений
        /// </summary>
        /// <param name="smtpAddress">адрес SMTP сервера</param>
        /// <param name="smtpPort">SMTP порт</param>
        /// <param name="outgoingMail">адрес исходящей почты</param>
        /// <param name="outgoingMailPassword">пароль исходящей почты</param>
        public EmailSendService(string smtpAddress, int smtpPort, string outgoingMail, string outgoingMailPassword)
        {
            SmtpAddress = smtpAddress;
            SmtpPort = smtpPort;
            OutgoingMail = outgoingMail;
            OutgoingMailPassword = outgoingMailPassword;
        }

        /// <summary>
        /// Отправить сообщение
        /// </summary>
        /// <param name="mail">адрес отправки</param>
        /// <param name="text">текст сообщения</param>
        public void SendTo(string mail, string text) => SendTo(mail, text, "");

        /// <summary>
        /// Отправить сообщение
        /// </summary>
        /// <param name="mail">адрес отправки</param>
        /// <param name="text">текст сообщения</param>
        /// <param name="title">заголовок сообщения</param>        
        public void SendTo(string mail, string text, string title)
        {
            if (string.IsNullOrEmpty(mail))
                throw new Exception("Адрес отправки не указан");

            using (MailMessage msg = new MailMessage(OutgoingMail, mail))
            {
                // формирование письма
                msg.Subject = title;        // Заголовок письма
                msg.Body = text;            // Тело письма
                
                msg.IsBodyHtml = false;     // html не используется в теле письма

                // Авторизация на smtp-сервере и отправление письма
                using (SmtpClient sc = new SmtpClient(SmtpAddress, SmtpPort))
                {
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential(OutgoingMail, OutgoingMailPassword);

                    sc.Send(msg);
                }
            }
        }
    }
}
