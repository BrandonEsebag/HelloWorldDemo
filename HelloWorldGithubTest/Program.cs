using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldGithubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry iph; //Device which IP is getting found
            string myip = ""; //An empty string, for now
            iph = Dns.GetHostEntry(Dns.GetHostName()); //This gets the IP Adress(s)
            foreach(IPAddress ip in iph.AddressList) //Check if each one is the right type
            {
                if(ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) //Tom my understanding this family connects to an endpoint, like a modem or pc
                {
                    myip = ip.ToString(); //The one that is connected to the computer
                }
            }
            Console.WriteLine("Your Device's name is " + Dns.GetHostName() + " and it's IP Adress it" + myip); //Write the IP out.
            Console.ReadLine();
        }
    }
}
