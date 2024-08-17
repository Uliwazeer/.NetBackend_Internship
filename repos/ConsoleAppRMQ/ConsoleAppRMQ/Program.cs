
using System;
using RabbitMQ.Client;
using System.Text;

namespace RabbitMQConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection settings
            var factory = new ConnectionFactory()
            {
                HostName = "localhost", // RabbitMQ server address
                Port = 5672,            // RabbitMQ port
                UserName = "guest",     // Default RabbitMQ username
                Password = "guest"      // Default RabbitMQ password
            };

            // Create a new connection to the RabbitMQ server
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                // Declare a queue (if not exists)
                string queueName = "myQueue";
                channel.QueueDeclare(queue: queueName,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                // Message to send
                string message = "Hello Brocker RabbitMQ, From EFG Hermes ,Eng.M/Bauymi!";
                var body = Encoding.UTF8.GetBytes(message);

                // Publish the message to the queue
                channel.BasicPublish(exchange: "",
                                     routingKey: queueName,
                                     basicProperties: null,
                                     body: body);

                Console.WriteLine(" [x] Sent '{0}'", message);
            }

            Console.WriteLine("Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}

