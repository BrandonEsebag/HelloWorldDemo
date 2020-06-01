using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;


namespace HelloWorldGithubTest
{
    class Program
    {
        public static string ip;
        static void Main(string[] args)
        {
            MainAsync();
            Console.ReadLine();
        }
        static async void MainAsync()
        {
            var httpClient = new HttpClient();
            ip = await httpClient.GetStringAsync("https://api.myip.com/");
            Info info = JsonConvert.DeserializeObject<Info>(ip);
            Console.WriteLine("This computer is in the country (the) " + info.country + ", shortened as " + info.cc + " with an IP adress of " + info.ip);
        }
    }
    public class Info
    {
        public Info(string eip, string ecountry, string ecc)
        {
            ip = eip;
            country = ecountry;
            cc = ecc;
        }
        public Info()
        {

        }
        public string ip;
        public string country;
        public string cc;
    }
}
