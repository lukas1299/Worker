using MongoDB.Driver;

namespace Worker.Infrastructure.Services.Abstract
{
    public interface IMongoClientProvider
    {
        MongoClient GetMongoClient();
    }
}