﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestSourceTree.Models;

namespace TestSourceTree.Managers
{
    class NetworkManager
    {
        public async Task<List<Comment>> GetCommentsTask()
        {
            WebClient client = new WebClient();
            string result = await client.DownloadStringTaskAsync("https://jsonplaceholder.typicode.com/comments");
            List<Comment> comments = JsonConvert.DeserializeObject<List<Comment>>(result);
            return comments;
        }
    }
}
