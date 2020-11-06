using System.Threading.Tasks;
using MongoDB.Driver;
using Worker.Application.Services;
using Worker.Core.Entities;
using Worker.Infrastructure.Mongo.Documents;

namespace Worker.Infrastructure.Services
{
    public class WorkerRepository : IWorkerRepository
    {
        public async Task Create(WorkerEntity worker)
        {
            var client = new MongoClient(
                "mongodb://localhost:27017"
            );
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<WorkerDocument>("workers");
            await collection.InsertOneAsync(new WorkerDocument {FirstName = worker.FirstName,LastName = worker.LastName, Age = worker.Age, Id = worker.Id});
        }
    }
}