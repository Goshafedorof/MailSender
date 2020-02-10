using MailSender.lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Services.Interfaces
{
    public interface IServersStore
    {
        IEnumerable<Server> Get();

        void Edit(int id, Server server);

        void Add(Server server);

        void SaveChanges();
    }
}
