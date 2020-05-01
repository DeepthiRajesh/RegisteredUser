using RegisteredUsers.Infrastructure.Common.Enums;
using System;
using static RegisteredUsers.Infrastructure.Common.Enums.EnumTypes;

namespace RegisteredUsers.DataAccess.Sql.Mapper.User
{
    public static class UserMapper
    {
        public static object RegisterdUser { get; private set; }

        public static Models.User ToUser(this Domain.Entities.Entity.User user)
        {
            return user != null ? new Models.User
            {
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                BirthDate = user.BirthDate,
                IsDeleted = false
            } : null;
        }

        public static Models.Login ToLogin(this Domain.Entities.Entity.User user, int userId)
        {
            return (user != null && userId > 0) ? new Models.Login 
            {
                UserId = userId,
                Email = user.Email,
                Password = user.Password,
                UserType = Convert.ToInt32(UserRoles.RegisterdUser)
            } : null;
        }

        public static Domain.Entities.Entity.UserDetail ToDomain(Models.User user, Models.Login login, Models.PersonalDetail personal)
        {
            return new Domain.Entities.Entity.UserDetail
            {
                UserId = user?.UserId ?? 0,
                FirstName = user?.FirstName,
                MiddleName = user?.MiddleName,
                LastName = user?.LastName,
                PhoneNumber = user?.PhoneNumber,
                BirthDate = user?.BirthDate ?? DateTime.MinValue,
                Email = login?.Email,
                UserType = login?.UserType ?? 0,
                Address = personal?.Address,
                City = personal?.City,
                State = personal?.State,
                Pincode = personal?.Pincode,
                Country = personal?.Country,
                Qualification = personal?.Qualification,
                JobTitle = personal?.JobTitle,
                Photo = personal?.Photo
            };
        }

        public static Models.User ToUser(this Domain.Entities.Entity.UserDetail userDetails, Models.User data)
        {
            if (userDetails != null)
            {
                data.FirstName = userDetails.FirstName;
                data.MiddleName = userDetails.MiddleName;
                data.LastName = userDetails.LastName;
                data.PhoneNumber = userDetails.PhoneNumber;
                data.BirthDate = userDetails.BirthDate;
            }
            return data;
        }

        public static Models.PersonalDetail ToUserDetails(this Domain.Entities.Entity.UserDetail userDetails, int userId)
        {
            return userDetails != null ? new Models.PersonalDetail
            {
                UserId = userId,
                Address = userDetails.Address,
                City = userDetails.City,
                State = userDetails.State,
                Pincode = userDetails.Pincode,
                Country = userDetails.Country,
                Qualification = userDetails.Qualification,
                JobTitle = userDetails.JobTitle,
                Photo = userDetails.Photo
            } : null;
        }
    }
}
