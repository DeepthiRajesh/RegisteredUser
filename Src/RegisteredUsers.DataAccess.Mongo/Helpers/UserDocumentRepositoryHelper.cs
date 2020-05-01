using RegisteredUsers.DataAccess.Mongo.Mdo;
using RegisteredUsers.DataAccess.Mongo.Mdo.User;
using RegisteredUsers.Domain.Entities.Document;
using RegisteredUsers.Infrastructure.Common.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace RegisteredUsers.DataAccess.Mongo.Helpers
{
    public static class UserDocumentRepositoryHelper
    {

        /*public static IList<UserDocument> ToUserDocument(this IList<UserDocumentMdo> documentMdos)
        {
            return documentMdos.IsNullOrEmpty() ? null : documentMdos.Select(x => x.ToUserDocument()).ToList();
        }

        public static UserDocument ToUserDocument(this UserDocumentMdo documentMdo)
        {
            return documentMdo != null ? new UserDocument
            {
                BirthDate = documentMdo.BirthDate,
                FirstName = documentMdo.FirstName,
                LastName = documentMdo.LastName,
                MiddleName = documentMdo.MiddleName,
                PhoneNumber = documentMdo.PhoneNumber,
                UserId = documentMdo.UserId
            } : null;
        }*/

        public static UserDetailDocument ToUserDocument(this UserDocumentMdo documentMdo)
        {
            return documentMdo != null ? new UserDetailDocument
            {
                BirthDate = documentMdo.BirthDate,
                FirstName = documentMdo.FirstName,
                LastName = documentMdo.LastName,
                MiddleName = documentMdo.MiddleName,
                PhoneNumber = documentMdo.PhoneNumber,
                UserId = documentMdo.UserId,
                
            } : null;
        }

    }
}
