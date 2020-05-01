using Microsoft.EntityFrameworkCore;
using RegisteredUsers.DataAccess.Sql.Models;

namespace RegisteredUsers.DataAccess.Sql.Core
{
    public class RepositoryContexts : DbContext
    {
        public RepositoryContexts(DbContextOptions<RepositoryContexts> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<PersonalDetail> PersonalDetails { get; set; }

    }
}
