using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections.Concurrent;

using OpTeamEngine.Messages;

namespace OpTeamEngine.Sources
{
    class ProjectClient
    {
        public delegate void ResponseHandler(MemoryStream response);
        public event ResponseHandler ResponseReceived = null;

        public ProjectClient(IPAddress ip, int port)
        {
            this.ip = ip;
            this.port = port;
            ipEndPoint = new IPEndPoint(ip, port);
            new Task(StartPerformTransactionCycle).Start();
            new Task(StartRouteResponseCycle).Start();
        }

        public void SendRequest(MemoryStream request)
        {
            requestQueue.Enqueue(request);
        }

        void StartPerformTransactionCycle()
        {
            while (true)
            {
                MemoryStream request = null;
                while (!requestQueue.TryDequeue(out request)) ;
                    
                Console.WriteLine("Trying to send request...");
                Console.WriteLine(Encoding.UTF8.GetString(request.GetBuffer()));

                byte[] bytes = new byte[1024];

                Socket sender = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect(this.ipEndPoint);
                }
                catch
                {
                    Console.WriteLine("Connection failed");
                    continue;
                }

                byte[] msg = request.GetBuffer();

                int bytesSent = sender.Send(msg);

                var aReceive = new Func<byte[], int>(sender.Receive);
                aReceive.BeginInvoke(bytes, () =>
                {
                    int result = aReceive.EndInvoke(c);
                    if (result == -1)
                    {
                        Console.WriteLine("Smth bad with returned result");
                    }

                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                    Console.WriteLine(Encoding.UTF8.GetString(bytes, 0, result));

                    MemoryStream response = new MemoryStream(bytes, 0, result, true, true);
                    responseQueue.Enqueue(response);
                }, null);               
            }
        }

        void StartRouteResponseCycle()
        {
            while (true)
            {
                MemoryStream xmlResponse = null;
                while (!responseQueue.TryDequeue(out xmlResponse)) ;

                ResponseReceived(xmlResponse);
            }
        }

        int port;
        IPAddress ip;
        IPEndPoint ipEndPoint;
        ConcurrentQueue<MemoryStream> requestQueue = new ConcurrentQueue<MemoryStream>();
        ConcurrentQueue<MemoryStream> responseQueue = new ConcurrentQueue<MemoryStream>();
    }
}

