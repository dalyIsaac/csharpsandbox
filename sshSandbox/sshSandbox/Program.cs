using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sshSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionInfo = new ConnectionInfo("hsotname",
                "username",
                new PasswordAuthenticationMethod("username", "password"));
            using (var client = new SshClient(connectionInfo))
            {
                client.Connect();
                Console.WriteLine($"The client is connected: {client.IsConnected}");
                Console.WriteLine($"Output: {client.CreateCommand("python ~Source/test.py").Execute()}");
                Console.ReadLine();
            }
        }
    }
}
