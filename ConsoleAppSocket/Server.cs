﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace ConsoleAppSocket
{
    class Server
    {
        public Server()
        {

        }

        public void SeverSocket()
        {
            int port = 6000;
            string host = "127.0.0.1";

            IPAddress ip = IPAddress.Parse(host);
            IPEndPoint ipe = new IPEndPoint(ip, port);

            Socket sSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sSocket.Bind(ipe);
            sSocket.Listen(0);
            Console.WriteLine("监听已经打开，请等待");

            //receive message
            Socket serverSocket = sSocket.Accept();
            Console.WriteLine("连接已经建立");
            string recStr = "";
            byte[] recByte = new byte[4096];
            int bytes = serverSocket.Receive(recByte, recByte.Length, 0);
            recStr += Encoding.ASCII.GetString(recByte, 0, bytes);

            //send message
            Console.WriteLine("服务器端获得信息:{0}", recStr);
            string sendStr = "send to client :hello";
            byte[] sendByte = Encoding.ASCII.GetBytes(sendStr);
            serverSocket.Send(sendByte, sendByte.Length, 0);
            serverSocket.Close();
            sSocket.Close();
        }
    }
}
