﻿using System;
using System.Collections.Generic;
using Beto.Core.Data;
using Beto.Core.Data.Users;

namespace DoctorHouse.Data
{
    public partial class User : IEntity
    {
        public User()
        {
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int? LocationId { get; set; }

        public DateTime CreationDate { get; set; }

        public string Password { get; set; }

        public string PasswordRecoveryToken { get; set; }

        public string Salt { get; set; }

        public bool Deleted { get; set; }

        public virtual Location Location { get; set; }
    }
}