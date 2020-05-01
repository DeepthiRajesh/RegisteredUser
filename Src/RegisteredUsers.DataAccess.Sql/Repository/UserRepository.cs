using RegisteredUsers.DataAccess.Sql.Mapper.User;
using RegisteredUsers.Domain.Abstract.Repository.Entity.User;
using RegisteredUsers.Domain.Entities.Entity;
using System;
using System.Linq;

namespace RegisteredUsers.DataAccess.Sql.Core
{
    public class UserRepository : IUserRepository
    {
        private readonly RepositoryContexts userDbContext;

        public UserRepository(RepositoryContexts userDbContext)
        {
            this.userDbContext = userDbContext;
        }

        public bool Registration(Domain.Entities.Entity.User user)
        {
            try
            {
                if (!this.IsUserExist(user.Email))
                {
                    var userData = user.ToUser();
                    this.userDbContext.Users.Add(userData);
                    this.userDbContext.SaveChanges();

                    this.userDbContext.Login.Add(user.ToLogin(userData.UserId));
                    this.userDbContext.SaveChanges();
                    return true;
                }
                else
                {
                    throw new ArgumentException("Email is already exists, plese try with another email!.");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool IsUserExist(string email)
        {
            return this.userDbContext.Login.Any(x => x.Email == email);
        }

        public int IsAuthorise(string email, string password)
        {
            var user= this.userDbContext.Login.FirstOrDefault(x => x.Email == email && x.Password == password && x.IsDeleted == false);
            return user.UserId;
            //return this.userDbContext.Login.Any(x => x.Email == email && x.Password == password && x.IsDeleted == false);
        }

        public UserDetail GetUserDetailsById(int userId)
        {
          var user =  this.userDbContext.Users.FirstOrDefault(x => x.UserId == userId && !x.IsDeleted);
          var login = this.userDbContext.Login.FirstOrDefault(x => x.UserId == userId && !x.IsDeleted);
          var personalDetails = this.userDbContext.PersonalDetails.FirstOrDefault(x => x.UserId == userId && !x.IsDeleted);

            return UserMapper.ToDomain(user, login, personalDetails);
        }

        public bool Update(UserDetail userDetails)
        {
            try
            {
                var data = this.userDbContext.Users.FirstOrDefault(x => x.UserId == userDetails.UserId);
                if (data != null)
                {
                    data = userDetails.ToUser(data);
                    var result = this.userDbContext.SaveChanges();

                    this.userDbContext.PersonalDetails.Add(userDetails.ToUserDetails(data.UserId));
                    this.userDbContext.SaveChanges();

                    return result > 0;
                }

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
