﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectFor.entities
{
    public class User
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int RoleId { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public Group Group { get; set; }
    }
}
