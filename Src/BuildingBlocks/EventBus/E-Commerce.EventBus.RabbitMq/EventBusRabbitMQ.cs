using E_Commerce.EventBus.Base.EventBus.Base;
using E_Commerce.EventBus.Base.Events;
using Newtonsoft.Json;
using Polly;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;
using System.Net.Sockets;
using System.Text;

namespace E_Commerce.EventBus.RabbitMq
{
    public class EventBusRabbitMQ : BaseEventBus
    {
        readonly RabbitMqConfig _conneciton;
        private readonly IConnectionFactory _connectionFactory;
        private readonly IModel _consumerChannel;
        public EventBusRabbitMQ(EventBusConfig config, IServiceProvider serviceProvider) : base(config, serviceProvider)
        {
            if (config.Connection != null)
            {
                var connjson = JsonConvert.SerializeObject(EventBusConfig!.Connection, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                _connectionFactory = JsonConvert.DeserializeObject<ConnectionFactory>(connjson)!;
            }
            else
                _connectionFactory = new ConnectionFactory();
            _conneciton = new RabbitMqConfig(_connectionFactory, config.ConnectionRetryCount, serviceProvider);
            _consumerChannel = CreateConsumerChannel();

            SubsManager.OnEventRemoved += SubsManager_OnEventRemoved;
        }

        private void SubsManager_OnEventRemoved(object? sender, string eventName)
        {
            eventName = ProcessEventName(eventName);
            if (!_conneciton.IsConnected)
                _conneciton.TryConnect();


            _consumerChannel.QueueUnbind(eventName, EventBusConfig!.DefaultTopicName, eventName);

            if (SubsManager.IsEmpty)
                _consumerChannel.Close();
        }

        public override void Publish(IntegrationEvent @event)
        {
            if (!_conneciton.IsConnected)
            {
                _conneciton.TryConnect();
            }

            var policy = Policy.Handle<BrokerUnreachableException>()
                .Or<SocketException>()
                .WaitAndRetry(EventBusConfig!.ConnectionRetryCount, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)), (ex, time) =>
                {
                    // log
                });

            var eventName = @event.GetType().Name;
            eventName = ProcessEventName(eventName);

            _consumerChannel.ExchangeDeclare(exchange: EventBusConfig.DefaultTopicName, type: "direct"); // Ensure exchange exists while publishing

            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(@event));

            policy.Execute(() =>
            {
                var properties = _consumerChannel.CreateBasicProperties();
                properties.DeliveryMode = 2;
                _consumerChannel.BasicPublish(
                    exchange: EventBusConfig.DefaultTopicName,
                    routingKey: eventName,
                    mandatory: true,
                    basicProperties: properties,
                    body: body);
            });
        }

        public override void Subscribe<T, TH>()
        {
            string eventName = ProcessEventName(typeof(T).Name);
            if (!SubsManager.HasSubscriptionsForEvent(eventName))
            {
                if (!_conneciton.IsConnected)
                    _conneciton.TryConnect();
                _consumerChannel.QueueDeclare(queue: GetSubName(eventName), true, false, false, null);
                _consumerChannel.QueueBind(GetSubName(eventName), EventBusConfig?.DefaultTopicName, eventName);
            }

            SubsManager.AddSubscription<T, TH>();
            StartBasicConsume(eventName);
        }

        public override void UnSubscribe<T, TH>()
        {
            SubsManager.RemoveSubscription<T, TH>();
        }

        private IModel CreateConsumerChannel()
        {
            if (!_conneciton.IsConnected)
                _conneciton.TryConnect();
            IModel channel = _conneciton.CreateModel();
            channel.ExchangeDeclare(exchange: EventBusConfig.DefaultTopicName, type: "direct");
            return channel;
        }

        private void StartBasicConsume(string eventName)
        {
            if (_consumerChannel is not null)
            {
                var consumer = new EventingBasicConsumer(_consumerChannel);

                consumer.Received += Consumer_Received;

                _consumerChannel.BasicConsume(
                    queue: GetSubName(eventName),
                    autoAck: false,
                    consumer: consumer);
            }
        }

        private async void Consumer_Received(object? sender, BasicDeliverEventArgs e)
        {
            string eventName = ProcessEventName(e.RoutingKey);
            try
            {
                await ProcessEvent(eventName, Encoding.UTF8.GetString(e.Body.Span));
            }
            catch (Exception)
            {
                throw;
            }

            _consumerChannel.BasicAck(e.DeliveryTag, false);
        }
    }


}
