using MailSender.lib.Entities;
using MailSender.lib.Services.InMemory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Tests.Services.InMemory
{
    [TestClass]
    public class ServersStoreInMemoryTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Check_uncorrectible_ID_of_method_Edit()
        {
            ServersStoreInMemory serverStore = new ServersStoreInMemory();

            serverStore.Edit(-1, new Server());
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Check_uncorrectible_Sender_of_method_Edit()
        {
            SendersStoreInMemory serverStore = new SendersStoreInMemory();

            serverStore.Edit(0, null);
        }

    }
}
