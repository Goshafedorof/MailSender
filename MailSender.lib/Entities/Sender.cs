using MailSender.lib.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Entities
{
    /// <summary>
    /// Описатель отправителя
    /// </summary>
    public class Sender : PersonEntity
    {
        public override string ToString() => $"{Name} :: {Address}";
    }
}
