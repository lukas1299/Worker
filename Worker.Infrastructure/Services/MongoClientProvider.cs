using MongoDB.Driver;
using Worker.Infrastructure.Options;
using Worker.Infrastructure.Services.Abstract;

namespace Worker.Infrastructure.Services
{
    public class MongoClientProvider : IMongoClientProvider
    {
        private readonly string _connection;

        public MongoClientProvider(MongoOptions option)
        {
            _connection = option.Address;
        }

        public MongoClient GetMongoClient()
            => new MongoClient(_connection);
    }
}