﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RegisteredUsers.DataAccess.Sql.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public bool IsDeleted { get; set; }

        public Login Login { get; set; }

    }
}
