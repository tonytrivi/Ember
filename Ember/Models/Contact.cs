﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ember.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}