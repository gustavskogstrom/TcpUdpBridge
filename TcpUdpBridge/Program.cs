using TcpUdpBridge;

namespace TcpUdpBridge;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 - Starta UDP");
        Console.WriteLine("2 - Starta TCP");

        var input = Console.ReadLine();

        if (input == "1")
        {
            UDPServer udpServer = new UDPServer();
            udpServer.Start();
        }
        else if (input == "2")
        {
            TCPServer tcpServer = new TCPServer();
            tcpServer.Start();
        }

        Console.ReadKey();
    }
}
