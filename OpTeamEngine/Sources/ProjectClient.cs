using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace OpTeamEngine.src
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
            Console.WriteLine(Encoding.UTF8.GetString(message.ToArray()));

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

            //asynchronous wait for response
            var aReceive = new Func<byte[], int>(sender.Receive);
            //FIX THIS BAD CODE ASAP
            aReceive.BeginInvoke(bytes, (aR) =>
            {
                int result = aReceive.EndInvoke(aR);
                if (result == -1)
                {
                    Console.WriteLine("Smth bad with returned result");
                }

                var client = aR.AsyncState as ProjectClient;
                client.ReceiveMessage(new MemoryStream(bytes));

                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }, this);
        }

        public void ReceiveMessage(MemoryStream message)
        {
            ResponseReceived(message);
        }

        public event ResponseHandler ResponseReceived;

        int port;
        IPAddress ip;
        IPEndPoint ipEndPoint;
    }
}

