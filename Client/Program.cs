using System;
using System.Threading.Tasks;
using Contracts;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var sender = new GrpcCoreSender();
            sender.Send(new Message
            {
                Subject = "Hello world 1",
                Created = DateTime.Now
            });

            await Task.Delay(1000);

            sender.Send(new Message
            {
                Subject = "Hello world 1",
                Created = DateTime.Now
            });

            await Task.Delay(1000);

            sender.Send(new Message
            {
                Subject = "Hello world 1",
                Created = DateTime.Now
            });

            await Task.Delay(1000);

            Console.WriteLine("Wiadomości wysłane");
            Console.ReadLine();
        }
    }
}
