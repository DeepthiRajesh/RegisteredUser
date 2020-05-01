using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisteredUsers.Presentation.UI.ViewModel
{
    public class UserDetailViewModel: UserViewModel
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string Country { get; set; }
        public string Qualification { get; set; }
        public string JobTitle { get; set; }
        public string Photo { get; set; }

    }
}
   