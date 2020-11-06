using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Worker.Application.DTOs;
using Worker.Application.Queries;

namespace Worker.Infrastructure.Queries.Handlers
{
    public interface IGetWorkersHandler
    {
        Task<IEnumerable<WorkerDto>> QueryAsync(GetWorkers query);
        
    }
}