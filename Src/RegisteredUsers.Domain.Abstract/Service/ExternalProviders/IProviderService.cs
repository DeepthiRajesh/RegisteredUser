using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RegisteredUsers.Domain.Abstract.Service.ExternalProviders
{
    public interface IProviderService
    { 
        Task<string> ReplicateUser(string uri); 
    }
}
