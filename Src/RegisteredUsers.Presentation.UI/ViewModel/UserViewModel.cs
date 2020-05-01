using System;

namespace RegisteredUsers.Presentation.UI.ViewModel
{
    public class UserViewModel : LoginViewModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
