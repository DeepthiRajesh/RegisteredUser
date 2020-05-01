using RegisteredUsers.Domain.Entities.Entity;
using RegisteredUsers.Presentation.UI.ViewModel;

namespace RegisteredUsers.Presentation.UI.Controllers.API.Helpers
{
    public static class UserControllerHelpers
    {
        public static User ToUserDomain(this UserViewModel model)
        {
            return model != null ? new User
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                BirthDate = model.BirthDate,
                IsDeleted = model.IsDeleted,
                Email = model.Email,
                Password = model.Password,
                UserType = model.UserType
            } : null;
        }

        public static UserDetail ToUpdateUserDomain(this UserDetailViewModel userModel)
        {
            return userModel != null ? new UserDetail
            {
                UserId = userModel.UserId,
                FirstName = userModel.FirstName,
                MiddleName = userModel.MiddleName,
                LastName = userModel.LastName,
                PhoneNumber = userModel.PhoneNumber,
                BirthDate = userModel.BirthDate,
                UserType = userModel.UserType,
                Address = userModel.Address,
                City = userModel.City,
                State = userModel.State,
                Pincode = userModel.Pincode,
                Country = userModel.Country,
                Qualification = userModel.Qualification,
                JobTitle = userModel.JobTitle,
                Photo = userModel.Photo
            } : null;

        }

        public static UserDetailViewModel ToUserDetailViewModel(this UserDetail userModel)
        {
            return userModel != null ? new UserDetailViewModel
            {
                UserId = userModel.UserId,
                FirstName = userModel.FirstName,
                MiddleName = userModel.MiddleName,
                LastName = userModel.LastName,
                PhoneNumber = userModel.PhoneNumber,
                BirthDate = userModel.BirthDate,
                UserType = userModel.UserType,
                Email = userModel.Email,
                Address = userModel.Address,
                City = userModel.City,
                State = userModel.State,
                Pincode = userModel.Pincode,
                Country = userModel.Country,
                Qualification = userModel.Qualification,
                JobTitle = userModel.JobTitle,
                Photo = userModel.Photo
            } : null;

        }
    }
}
