using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelloWorldGithubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync();
            Console.ReadLine();
        }
        static async void MainAsync()
        {
            var httpClient = new HttpClient();
            var ip = await httpClient.GetStringAsync("https://api.ipify.org");
            Console.WriteLine($"My public IP address is: {ip}");
        }
    }
}
