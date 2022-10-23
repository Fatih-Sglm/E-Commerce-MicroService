using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Polly;
using Polly.Retry;
using RabbitMQ.Client;
using RabbitMQ.Client.Exceptions;
using System.Net.Sockets;

namespace E_Commerce.EventBus.RabbitMq
{
    public class RabbitMqConfig : IDisposable
    {
        private IConnection _connection;
        private readonly IConnectionFactory _connectionFactory;
        private readonly int _retryCount;
        private readonly ILogger _logger;
        private readonly IServiceProvider _serviceProvider;
        public bool IsConnected => _connection != null && _connection.IsOpen;
        private readonly object _locker = new();
        private bool _disposed;


        public RabbitMqConfig(IConnectionFactory connectionFactory, int retryCount, IServiceProvider serviceProvider)
        {
            _connectionFactory = connectionFactory;
            _retryCount = retryCount;
            _serviceProvider = serviceProvider;
            _logger = _serviceProvider.GetRequiredService<ILogger<RabbitMqConfig>>(); ;
        }

        public IModel CreateModel()
        {
            return _connection.CreateModel();
        }
        public void Dispose()
        {
            _disposed = true;
            _connection?.Dispose();
        }

        public bool TryConnect()
        {
            lock (_locker)
            {
                RetryPolicy policy = Policy.Handle<SocketException>().Or<BrokerUnreachableException>().
                    WaitAndRetry(_retryCount, _retryAttemp => TimeSpan.FromSeconds(Math.Pow(2, _retryAttemp)), (ex, time) =>
                    {

                    });

                policy.Execute(() =>
                {

                    _connection = _connectionFactory.CreateConnection();
                    _logger.LogInformation("Rabbit MQ Connection is Succesfull");
                });

                if (IsConnected)
                {
                    _connection.ConnectionShutdown += Connection_ConnectionShutdown;
                    _connection.CallbackException += Connection_CallbackException;
                    _connection.ConnectionUnblocked += Connection_ConnectionUnblocked;
                    return true;
                }
                return false;
            }

        }

        private void Connection_ConnectionUnblocked(object? sender, EventArgs e)
        {
            TryReconnect();
        }

        private void Connection_ConnectionShutdown(object? sender, ShutdownEventArgs e)
        {
            TryReconnect();
        }

        private void Connection_CallbackException(object? sender, RabbitMQ.Client.Events.CallbackExceptionEventArgs e)
        {
            TryReconnect();
        }
        private void TryReconnect()
        {
            if (_disposed) return;
            TryConnect();
        }
    }
}
