using System;
using Microsoft.Owin.Hosting;

namespace POC_SelfHost {
    class Program {
        static void Main(string[] args) {
            using (WebApp.Start<Startup>("http://localhost:12345")) {
                Console.WriteLine("Servidor online!");
                Console.ReadLine();
            }
        }
    }
}
