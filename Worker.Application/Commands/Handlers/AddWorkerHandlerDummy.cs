using System;
using System.Threading.Tasks;

namespace Worker.Application.Commands.Handlers
{
    public class AddWorkerHandlerDummy : IAddWorkerHandler
    {
        public async Task HandleAsync(AddWorker command)
        {
            Console.WriteLine("AddWorkerHandler123");
        }
        
    }
}