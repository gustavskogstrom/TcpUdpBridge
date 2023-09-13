using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TcpUdpBridge;

public class UDPServer
{
    UdpClient udpListener = new UdpClient(Settings.UDP_PORT);

    public UDPServer()
    {
        Console.WriteLine("UDP Server started. Waiting for messages...");

        while (true)
        {
            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, Settings.UDP_PORT);

            byte[] buffer = udpListener.Receive(ref clientEndPoint);
            string message = Encoding.ASCII.GetString(buffer);
            Console.WriteLine("UDP Message received: " + message);
        }
    }
    internal void Start()
    {

    }
}