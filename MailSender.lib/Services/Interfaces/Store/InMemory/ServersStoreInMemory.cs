using MailSender.lib.Data;
using MailSender.lib.Entities;

namespace MailSender.lib.Services.Interfaces.Store.InMemory
{
    public class ServersStoreInMemory : DataStoreInMemory<Server>, IServersStore
    {
        public ServersStoreInMemory() : base(TestData.Servers) { }

        public override void Edit(int id, Server server)
        {
            var db_server = GetById(id);
            if (db_server is null) return;

            // Имитация работы не с объектами в памяти, а с объектам в БД
            db_server.Port = server.Port;
            db_server.Name = server.Name;
            db_server.Login = server.Login;
            db_server.UseSSL = server.UseSSL;            
            db_server.Address = server.Address;
            db_server.Password = server.Password;
        }
    }
}
