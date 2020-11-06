using System.Threading.Tasks;
using Worker.Application.DTOs;
using Worker.Application.Queries;

namespace Worker.Infrastructure.Queries.Handlers
{
    public interface IAboutMeHandler
    {
        Task<AboutDto> QueryAsync(AboutMe query);
    }
}