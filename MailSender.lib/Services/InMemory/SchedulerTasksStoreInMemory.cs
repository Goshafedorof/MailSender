using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces.Store;

namespace MailSender.lib.Services.InMemory
{
    /// <summary>
    /// Реализация хранения планировщика задач
    /// </summary>
    public class SchedulerTasksStoreInMemory : DataStoreInMemory<SchedulerTask>, ISchedulerTasksStore
    {
        public SchedulerTasksStoreInMemory() : base(null) { }
        
        public override void Edit(int id, SchedulerTask item)
        {
            throw new System.NotImplementedException();
        }
    }

}
