using MailSender.lib.Entities;


namespace MailSender.lib.Services.Interfaces.Store
{
    /// <summary>
    /// Хранилище списка писем
    /// </summary>
    public interface IMailsStore : IDataStore<Mail> { }
}
