using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RegisteredUsers.Domain.Abstract.ExternalProvider
{
    public interface IProviderBase  
    {
        Task<string> ReplicateUser(string uri); 

    }
}
