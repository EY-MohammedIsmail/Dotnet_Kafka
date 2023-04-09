using Confluent.Kafka;
using System;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "my-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using (var consumer = new ConsumerBuilder<Ignore, string>(config).Build())
        {
            consumer.Subscribe("ditnet2");

            while (true)
            {
                var result = consumer.Consume();

                Console.WriteLine($"Consumed message '{result.Value}' at: '{result.TopicPartitionOffset}'.");
            }
        }
    }
}
