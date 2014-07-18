using System;
using Microsoft.Owin.Hosting;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start("http://localhost:61201"))
            {
                Console.WriteLine("Server running at http://localhost:61201/");
                Console.ReadLine();
            }
        }
    }
}
