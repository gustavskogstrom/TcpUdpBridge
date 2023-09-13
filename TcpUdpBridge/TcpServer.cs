using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TcpUdpBridge;

public class TCPServer
{

    TcpListener tcpListener = new TcpListener(IPAddress.Any, Settings.TCP_PORT);

    public TCPServer()
    {
        tcpListener.Start();
        Console.WriteLine("TCP Server started. Waiting for connections...");

        while (true)
        {
            TcpClient client = tcpListener.AcceptTcpClient();
            Console.WriteLine("TCP Client connected.");

            NetworkStream stream = client.GetStream();

            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine("TCP Message received: " + message);

            stream.Close();
            client.Close();
        }
    }

    internal void Start()
    {

    }
}