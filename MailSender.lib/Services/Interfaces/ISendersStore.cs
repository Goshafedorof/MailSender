using MailSender.lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Services.Interfaces
{
    public interface ISendersStore
    {
        IEnumerable<Sender> Get();

        void Edit(int id, Sender sender);

        void Add(Sender sender);

        void SaveChanges();
    }
}
