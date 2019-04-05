using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace TCPClientExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //make sure the server is running before we try to connect
            //DO THIS ONLY IN DEBUG
            Thread.Sleep(500);

            using (TcpClient client = new TcpClient("127.0.0.1", MiniSQLEngine.Network.TCPPort))
            {
                NetworkStream networkStream = client.GetStream();

                byte[] outputBuffer = Encoding.ASCII.GetBytes("Do you want to marry me????");
                byte[] inputBuffer = new byte[1024];
                byte[] endMessage = Encoding.ASCII.GetBytes("END");

                for (int i = 0; i < 5; i++)
                {
                    networkStream.Write(outputBuffer, 0, outputBuffer.Length);

                    int readBytes = networkStream.Read(inputBuffer, 0, 1024);
                    Console.WriteLine("Response received: " + Encoding.ASCII.GetString(inputBuffer,0,readBytes));
                }
                networkStream.Write(endMessage, 0, endMessage.Length);
            }
        }
    }
}
