using MailSender.lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Services.Interfaces
{
    public interface ISendersManager
    {
        IEnumerable<Sender> GetAll();

        void Add(Sender newSender);

        void Edit(Sender sender);

        void SaveChanges();
    }
}
