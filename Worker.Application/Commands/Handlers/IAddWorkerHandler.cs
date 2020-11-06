using System.Threading.Tasks;

namespace Worker.Application.Commands.Handlers
{
    public interface IAddWorkerHandler
    {
        Task HandleAsync(AddWorker command);
    }
}