using System.Threading.Tasks;
using Worker.Application.Services;
using Worker.Core.Entities;

namespace Worker.Application.Commands.Handlers
{
    public class AddWorkerHandler : IAddWorkerHandler
    {
        private readonly IWorkerRepository _workerRepository;

        public AddWorkerHandler(IWorkerRepository workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public async Task HandleAsync(AddWorker command)
        {
            
            WorkerEntity workerEntity = WorkerEntity.Create(command.Id, command.FirstName, command.LastName, command.Age);
            await _workerRepository.Create(workerEntity);
        }
        
    }
}