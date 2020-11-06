using System.Threading.Tasks;
using MongoDB.Driver;
using Worker.Application.Services;
using Worker.Core.Entities;
using Worker.Infrastructure.Mongo.Documents;
using Worker.Infrastructure.Services.Abstract;

namespace Worker.Infrastructure.Services
{
    public class WorkerRepository : IWorkerRepository
    {
        private readonly IMongoClientProvider _mongoClientProvider;

        public WorkerRepository(IMongoClientProvider mongoClientProvider)
        {
            _mongoClientProvider = mongoClientProvider;
        }

        public async Task Create(WorkerEntity worker)
        {
            var client = _mongoClientProvider.GetMongoClient();
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<WorkerDocument>("workers");
            await collection.InsertOneAsync(new WorkerDocument {FirstName = worker.FirstName,LastName = worker.LastName, Age = worker.Age, Id = worker.Id});
        }
    }
}