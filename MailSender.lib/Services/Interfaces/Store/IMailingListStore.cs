using MailSender.lib.Entities;


namespace MailSender.lib.Services.Interfaces.Store
{
    /// <summary>
    /// Хранилиде списка отправлений
    /// </summary>
    public interface IMailingListStore : IDataStore<MailingList> { }
}
