﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailBox.Models
{
    public class Role
    {
        public string Name { get; }

        public Role(string name)
        {
            this.Name = name;
        }
    }
}