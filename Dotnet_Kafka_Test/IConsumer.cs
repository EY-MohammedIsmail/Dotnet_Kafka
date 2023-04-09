using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Kafka_Test
{
    public interface IConsumer
    {
        void Listen(Func<string> message);
    }
}
