using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestSourceTree.Models;

namespace TestSourceTree
{
    class Program
    {
        static async void Main(string[] args)
        {
            WebClient client = new WebClient();
            try
            {
                string result = await client.DownloadStringTaskAsync("https://jsonplaceholder.typicode.com/comments");
                List<Comment> comments = JsonConvert.DeserializeObject<List<Comment>>(result);
                foreach (var comment in comments)
                {
                    Console.WriteLine(comment.Name);
                }
            }
            catch(WebException)
            {
                Console.WriteLine("No internet");
            }
            
        }
    }
}
