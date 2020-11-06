using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Worker.Application.DTOs;
using Worker.Application.Queries;
using Worker.Infrastructure.Mongo.Documents;

namespace Worker.Infrastructure.Queries.Handlers
{
    public class GetWorkersHandler : IGetWorkersHandler
    {
        public async Task<IEnumerable<WorkerDto>> QueryAsync(GetWorkers query)
        {
            MongoClient client = new MongoClient(
                "mongodb://localhost:27017"
            );
            IMongoDatabase database = client.GetDatabase("test");
            
            IMongoCollection<WorkerDocument> collection = database.GetCollection<WorkerDocument>("workers");
            
            List<WorkerDocument> workerDocuments = await collection.Find(x => true).ToListAsync();
            
            IEnumerable<WorkerDto> workerDtoList = workerDocuments.Select(AsDto);
            
            return workerDtoList;
        }

        private static WorkerDto AsDto(WorkerDocument worker)
            => new WorkerDto { FirstName = worker.FirstName,LastName = worker.LastName, Age = worker.Age, Id = worker.Id};
        
    }
}