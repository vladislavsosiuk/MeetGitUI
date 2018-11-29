using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestSourceTree.Models;

namespace TestSourceTree.Managers
{
    class NetworkManagerException: Exception
    {
        public NetworkManagerException(string message) : base(message) { }
    }

    class NetworkManager
    {
        public async Task<List<Comment>> GetCommentsTask()
        {
            WebClient client = new WebClient();
            try
            {
                string result = await client.DownloadStringTaskAsync("https://jsonplaceholder.typicode.com/comments");
                List<Comment> comments = JsonConvert.DeserializeObject<List<Comment>>(result);
                return comments;
            }
            catch (WebException)
            {
                throw new NetworkManagerException("No internet");
            }
        }
    }
}
