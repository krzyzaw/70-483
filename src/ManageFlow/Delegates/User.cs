﻿using System;

namespace ManageFlow.Delegates
{
    public class User : Entity
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}