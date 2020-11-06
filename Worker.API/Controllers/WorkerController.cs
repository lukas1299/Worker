using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Worker.API.Models;
using Worker.Application.Commands;
using Worker.Application.Commands.Handlers;
using Worker.Application.Queries;
using Worker.Infrastructure.Queries.Handlers;


namespace Worker.API.Controllers
{
    [ApiController]
    [Route("api/workers")]
    public class WorkerController : ControllerBase
    {

        private readonly IAddWorkerHandler _addWorkerHandler;
        private readonly IGetWorkersHandler _getWorkersHandler;

        public WorkerController(IAddWorkerHandler addWorkerHandler, IGetWorkersHandler getWorkersHandler)
        {
            _addWorkerHandler = addWorkerHandler;
            _getWorkersHandler = getWorkersHandler;
        }

        [HttpPost]
        public async Task<ActionResult> AddWorkerPost(AddWorkerRequestModel addWorkerRequestModel)
        {
            Guid newWorkerId = Guid.NewGuid();
            
            AddWorker command = new AddWorker(newWorkerId, addWorkerRequestModel.FirstName,
                addWorkerRequestModel.LastName, addWorkerRequestModel.Age.ToString());
            
            await _addWorkerHandler.HandleAsync(command);
            
            return Created(($"api/worker/{newWorkerId}"), null);
            
        }

        [HttpGet]
        public async Task<ActionResult> Get()
            => Ok(await _getWorkersHandler.QueryAsync(new GetWorkers()));
        
    }
}