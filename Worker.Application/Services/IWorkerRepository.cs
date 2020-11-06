using System.Threading.Tasks;
using Worker.Core.Entities;

namespace Worker.Application.Services
{
    public interface IWorkerRepository
    {
        Task Create(WorkerEntity worker);
    }
}