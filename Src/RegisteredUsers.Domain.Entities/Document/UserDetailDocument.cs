using System;
using System.Collections.Generic;
using System.Text;

namespace RegisteredUsers.Domain.Entities.Document
{
    public class UserDetailDocument : UserDocument
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
