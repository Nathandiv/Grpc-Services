using awesomeServices;
using Grpc.Net.Client;

Console.WriteLine("please enter a name:");
var name = Console.ReadLine();

using var channel = GrpcChannel.ForAddress ("http://localhost:7139");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest{Name =name});
Console.WriteLine("Greeting:"+reply.Message);
Console.ReadKey();
{
    
}