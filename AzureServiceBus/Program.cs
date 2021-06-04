using System;
using System.Threading.Tasks;

namespace AzureServiceBus
{
    //Refrence Source code from: https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-dotnet-get-started-with-queues
    class Program
    {
        static async Task Main(string[] args)
        {
            //how to get connection string? here is the docuement
            //https://social.msdn.microsoft.com/Forums/azure/en-US/c8edd9b5-76ea-4d93-8025-2e9d90b5ddf4/where-to-find-the-connectionstring-in-the-new-service-bus-portal?forum=servbus
            var connectionString = "Endpoint=sb://sbs-usw1-ood-slot1-dev.servicebus.windows.net/;SharedAccessKeyName=admin;SharedAccessKey=PCelvETZinCvNGP4suHM4bW3MNtCH4LpijX9ol7y2wU=;EntityPath=pdm-test-queue";
            var queueName = "pdm-test-queue";

            // send a message to the queue
            await QueueSender.SendMessageAsync(connectionString, queueName);

            // send a batch of messages to the queue
            // await QueueSender.SendMessageBatchAsync(connectionString, queueName);


           await QueueReciever.ReceiveMessagesAsync(connectionString, queueName);
        }
    }
}
