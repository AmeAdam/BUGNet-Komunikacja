using System;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new GrpcServer();
            server.Host();
        }
    }
}
