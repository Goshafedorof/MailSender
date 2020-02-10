using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces.Manager;
using MailSender.lib.Services.Interfaces.Store;

namespace MailSender.lib.Services.Managers
{
    public class SchedulerTasksManager : DataManager<SchedulerTask>, ISchedulerTaskManager
    {
        public SchedulerTasksManager(ISchedulerTasksStore schedulerTasksStore) : base(schedulerTasksStore) { }
    }
}
