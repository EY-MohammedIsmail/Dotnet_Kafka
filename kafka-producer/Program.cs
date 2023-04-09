using Confluent.Kafka;
using System;

class Program
{
    static void Main(string[] args)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

        using (var producer = new ProducerBuilder<Null, string>(config).Build())
        {
            string topic = "ditnet2";
            string message = "Hello, Kafka! from dotnet";

            var result = producer.ProduceAsync(topic, new Message<Null, string> { Value = message }).GetAwaiter().GetResult();

            Console.WriteLine($"Produced message to topic {result.Topic}, partition {result.Partition}, offset {result.Offset}");
        }
    }
}
