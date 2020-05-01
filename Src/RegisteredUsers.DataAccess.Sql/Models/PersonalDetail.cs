using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegisteredUsers.DataAccess.Sql.Models
{
    public class PersonalDetail
    {
        [Key]
        public int PersonalDetailId { get; set; }

        public int UserId { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Pincode { get; set; }

        public string Country { get; set; }

        public string Qualification { get; set; }

        public string JobTitle { get; set; }

        public string Photo { get; set; }

        public bool IsDeleted { get; set; }

        public User User { get; set; }
    }
}
