using System;

namespace ConsoleAppSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.Read();
            Server s = new Server();
            s.SeverSocket();
        }
    }
}
