using System.Threading.Tasks;
using Worker.Application.DTOs;
using Worker.Application.Queries;

namespace Worker.Infrastructure.Queries.Handlers
{
    public class AboutMeHandler : IAboutMeHandler
    {
        public Task<AboutDto> QueryAsync(AboutMe query)
         => Task.FromResult(new AboutDto
            {
                FirstName = "Łukasz",
                LastName = "Matusik"
            });
        
    }
}