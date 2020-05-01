using RegisteredUsers.Domain.Abstract.ExternalProvider;
using RegisteredUsers.Domain.Abstract.Service.ExternalProviders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RegisteredUsers.Domain.Service.ExternalProvider
{
    public class ProviderService : IProviderService
    {
        private readonly IProviderBase providerBase;

        public ProviderService(IProviderBase providerBase)
        {
            this.providerBase = providerBase;
        }
        public async Task<string> ReplicateUser(string uri) 
        {
            return await this.providerBase.ReplicateUser(uri);

        }

    }
}
