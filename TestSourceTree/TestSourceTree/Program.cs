using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestSourceTree.Managers;
using TestSourceTree.Models;

namespace TestSourceTree
{
    class Program
    {
        static async void Main(string[] args)
        {
            NetworkManager networkManager = new NetworkManager();
            try
            {
                var comments = await networkManager.GetCommentsTask();
                foreach (var comment in comments)
                {
                    Console.WriteLine(comment.Name);
                }
            }
            catch(NetworkManagerException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
