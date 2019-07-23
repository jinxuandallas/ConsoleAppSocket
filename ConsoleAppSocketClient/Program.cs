using System;

namespace ConsoleAppSocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Client c = new Client();
            c.ClientSocket();
        }
    }
}
