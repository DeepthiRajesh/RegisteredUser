﻿using RegisteredUsers.Domain.Entities.Document;
using System;

namespace RegisteredUsers.Presentation.API.ViewModel
{
    public class UserViewModel : PersonalDetailsViewModel
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public bool IsDeleted { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int UserType { get; set; }

        public UserDetailDocument DetailDocument { get; set; }
    }
}
