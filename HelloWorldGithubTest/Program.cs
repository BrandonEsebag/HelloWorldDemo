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
            var ip = await httpClient.GetStringAsync("https://api.myip.com/");
            ip = ip.Replace("{\"ip\":\"", "Your IP Adress is ");
            ip = ip.Replace("\",\"country\":\""," and falls within (the) ");
            ip = ip.Substring(0, ip.Length - 12);
            Console.WriteLine(ip);
        }
    }
}
