using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RegisteredUsers.DataAccess.ExternalProviders.ServiceBase
{
    public class ProviderBase
    {
        public async Task<string> ReplicateUser(string uri) 
        { 
            string payLoad = null;
            using (var handler = new HttpClientHandler())
            {

                using (var httpClient = new HttpClient(handler))
                {
                    var response = await httpClient.PostAsync(uri, new StringContent(payLoad, Encoding.UTF8, "application/json"));
                    var content = string.Empty;

                    if (response.StatusCode != HttpStatusCode.NoContent)
                    {
                        content = await response.Content.ReadAsStringAsync();
                    }

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpException(Convert.ToInt32(response.StatusCode), content);
                    }

                    return content;
                }
            }
        }
    }
}
