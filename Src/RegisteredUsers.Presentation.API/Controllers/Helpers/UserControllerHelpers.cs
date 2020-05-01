using RegisteredUsers.Domain.Entities.Document;
using RegisteredUsers.Domain.Entities.Entity;
using RegisteredUsers.Presentation.API.ViewModel;

namespace RegisteredUsers.Presentation.API.Controllers.Helpers
{
    public static class UserControllerHelpers
    {
        public static UserViewModel ToUserDetailViewModel(this UserDetailDocument userModel)
        {
            return userModel != null ? new UserViewModel
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

        public static UserDetailDocument ToUserDetailDocument(this UserDetail model)
        {
            return model != null ? new UserDetailDocument
            {
                UserId = model.UserId,
                Address = model.Address,
                BirthDate = model.BirthDate,
                City = model.City,
                State = model.State,
                Pincode = model.Pincode,
                Country = model.Country,
                Qualification = model.Qualification,
                JobTitle = model.JobTitle,
                Photo = model.Photo,
                Email = model.Email,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                UserType = model.UserType
            } : null;
        }

    }
}
