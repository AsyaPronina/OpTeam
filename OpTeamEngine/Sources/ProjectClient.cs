using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace OpTeamEngine.Sources
{
    delegate void ResponseHandler(MemoryStream message);

    class ProjectClient
    {
        public ProjectClient(IPAddress ip, int port)
        {
            this.ip = ip;
            this.port = port;
            ipEndPoint = new IPEndPoint(ip, port);
        }

        public void SendMessage(MemoryStream message)
        {
            Console.WriteLine("Trying to send message...");
            Console.WriteLine(Encoding.UTF8.GetString(message.GetBuffer()));

            byte[] bytes = new byte[1024];

            Socket sender = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sender.Connect(this.ipEndPoint);
            }
            catch
            {
                Console.WriteLine("Connection failed");
                return;
            }

            byte[] msg = message.GetBuffer();

            int bytesSent = sender.Send(msg);
            int bytesRec = sender.Receive(bytes);

            sender.Shutdown(SocketShutdown.Both);
            sender.Close();

            Console.WriteLine(Encoding.UTF8.GetString(bytes, 0, bytesRec));

            ResponseReceived(new MemoryStream(bytes, 0, bytes.Length, true, true));
        }

        public event ResponseHandler ResponseReceived;

        int port;
        IPAddress ip;
        IPEndPoint ipEndPoint;
    }
}

