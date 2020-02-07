using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.lib.Entities;

namespace MailSender.lib.Services.Interfaces
{
    public interface IServersManager
    {
        IEnumerable<Server> GetAll();

        void Add(Server newServer);

        void Edit(Server server);

        void SaveChanges();
    }
}
