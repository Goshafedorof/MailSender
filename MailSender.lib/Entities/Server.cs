using MailSender.lib.Entities.Base;

namespace MailSender.lib.Entities
{
    /// <summary>
    /// Описатель почтового сервера
    /// </summary>
    public class Server : NamedEntity
    {
        /// <summary>
        /// Адрес сервера
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Порт сервера
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// Флаг"Использование SSL"
        /// </summary>
        public bool UseSSL { get; set; } = true;
        /// <summary>
        /// Логин учетной записи отправителя
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль от учетной записи отправителя
        /// </summary>
        public string Password { get; set; }
    }
}
