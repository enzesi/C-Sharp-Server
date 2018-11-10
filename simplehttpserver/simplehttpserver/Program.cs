using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace WebTestServer
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServer ws = new WebServer("http://localhost:8080/");
            ws.Run();
            Console.WriteLine("A simple webserver. Press a key to quit.");
            Console.ReadKey();
            ws.Stop();
        }
    }
}
