using MailSender.lib.Entities;


namespace MailSender.lib.Services.Interfaces.Store
{
    /// <summary>
    /// Хранилиже планировщика
    /// </summary>
    public interface ISchedulerTasksStore : IDataStore<SchedulerTask> { }
}
