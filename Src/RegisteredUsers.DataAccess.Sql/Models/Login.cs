
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegisteredUsers.DataAccess.Sql.Models
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public bool IsDeleted { get; set; }

        public User User { get; set; }
    }
}
