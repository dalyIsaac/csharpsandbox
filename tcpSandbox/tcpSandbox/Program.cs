using SimpleTCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcpSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new SimpleTcpClient().Connect("192.168.1.20", 10000);
            var replyMsg = client.WriteLineAndGetReply("Hello world!", TimeSpan.FromSeconds(3));
            Console.WriteLine($"Got {replyMsg.MessageString}");
            client.Disconnect();
            Console.ReadLine();
        }
    }
}
