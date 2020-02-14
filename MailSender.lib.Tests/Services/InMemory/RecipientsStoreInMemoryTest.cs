using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.lib.Entities;
using MailSender.lib.Services.InMemory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailSender.lib.Tests.Services.InMemory
{
    [TestClass]
    public class RecipientsStoreInMemoryTest
    {
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Check_uncorrectible_ID_of_method_Edit()
        {
            RecipientsStoreInMemory recipientStore = new RecipientsStoreInMemory();

            recipientStore.Edit(-1, new Recipient());
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Check_uncorrectible_Recipient_of_method_edit()
        {
            RecipientsStoreInMemory recipentStore = new RecipientsStoreInMemory();

            recipentStore.Edit(0, null);
        }
    }
}
