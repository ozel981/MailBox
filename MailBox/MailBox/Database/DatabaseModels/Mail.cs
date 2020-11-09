﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailBox.Database
{
    public class Mail
    {
        public Guid ID { get; set; }
        public string Topic { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public bool Read { get; set; }
        public User Sender { get; set; }
        public ICollection<UserMail> UserMails { get; set; } //Recipients
        public Mail MailReply { get; set; }
        public ICollection<Mail> Mails { get; set; }
    }
}